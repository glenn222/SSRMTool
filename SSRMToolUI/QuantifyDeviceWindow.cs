using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSRMTool;
using System.Threading.Tasks;

namespace SSRMToolUI
{
    public partial class QuantifyDeviceWindow : Form
    {
        private static QuantifyDeviceWindow _quantifyDeviceWindow = null;
        private DeviceManager _deviceManager = new DeviceManager();
        private string _fileName;
        private Staircase _currentStairCase;
        private Measurement _currentMeasurement;
        private List<int[]> _polygonPoints = new List<int[]>();
        private List<List<int[]>> _regions = new List<List<int[]>>();
        private static readonly string FILE_DIALOG_JPG_FILTER = "JPEG File|*.jpg";
        private static readonly string FILE_DIALOG_FILTER = "Gwyddion File|*.gwy";

        private Task<Bitmap> NewImage;

        private QuantifyDeviceWindow()
        {
            InitializeComponent();
            PopulateDataChannelDropDownMenu();
            PopulateFunctionsDropDownMenu();
        }

        public static QuantifyDeviceWindow GetQuantifyDeviceInstance()
        {
            if (_quantifyDeviceWindow == null || _quantifyDeviceWindow.IsDisposed)
                _quantifyDeviceWindow = new QuantifyDeviceWindow();

            return _quantifyDeviceWindow;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = FILE_DIALOG_FILTER;
                dialog.ShowDialog();

                // Check if file was selected
                if (!string.IsNullOrEmpty(dialog.FileName))
                {
                    _fileName = dialog.FileName;
                    txtArea_GwyFilePath.Text = dialog.FileName;
                    
                }
            }
        }

        private void PopulateDataChannelDropDownMenu()
        {
            foreach (string channelName in _deviceManager.ChannelIndex.Values)
            {
                dropdown_DataChannels.Items.Add(channelName);
            }
        }

        private void PopulateFunctionsDropDownMenu()
        {
            dropdown_MeasurementFunctions.Items.Clear();
            foreach (string functionName in _deviceManager.FuncIndexToString.Values)
            {
                dropdown_MeasurementFunctions.Items.Add(functionName);
            }
        }

        private void btn_OpenStaircase_Click(object sender, EventArgs e)
        {
            Hide();
            OpenStaircaseDataWindow.GetInstance(this).Show();
        }

        private void dropdown_Measurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentStairCase == null)
            {
                MessageBox.Show(StringConstants.ERROR_NO_STAIRCASE_DEFINED);
                return;
            }

            var measurementsComboBox = (ComboBox)sender;

            if (measurementsComboBox.SelectedIndex >= 0)
            {
                var index = measurementsComboBox.SelectedIndex;
                var measurement = _currentStairCase.MeasuredData[index];

                _currentMeasurement = _currentStairCase.MeasuredData[index];
            }
        }

        private void dropdown_MeasurementFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentMeasurement == null)
            {
                MessageBox.Show(StringConstants.ERROR_NO_MEASUREMENT_DEFINED);
                return;
            }

            var functionsComboBox = (ComboBox)sender;

            if (functionsComboBox.SelectedIndex >= 0)
            {
                var index = functionsComboBox.SelectedIndex;
                PopulateFunctionExpression(index);
                
                btn_GenerateRegion.Enabled = true;
            }
        }

        private async void dropdown_DataChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_fileName))
            {
                MessageBox.Show("Please open a gwyddion file first");
                return;
            }

            var dataChannelComboBox = (ComboBox)sender;
            var index = dataChannelComboBox.SelectedIndex;

            Bitmap image = await _deviceManager.GetChannelImage(dataChannelComboBox.Items[index].ToString(), index);
            pictureBox_GwyddionImage.Image = image;

            // TODO:: Check bitmap creation to see if it can flip values.
            pictureBox_GwyddionImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // TODO:: Get image for that certain data channel.
        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (_currentMeasurement == null)
            {
                MessageBox.Show(StringConstants.ERROR_NO_MEASUREMENT_DEFINED);
                return;
            }

            var index = dropdown_MeasurementFunctions.SelectedIndex;
            
            Bitmap newImage = await _deviceManager.CalculateNewImage(_currentMeasurement, index, _regions, _currentStairCase.StaircaseMaterial);

            pictureBox_ProcessedGwyddionImage.Image = newImage;
            pictureBox_ProcessedGwyddionImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        public void PopulateStairCase(Staircase stairCase)
        {
            ClearCurrentStairCase();
            ClearAllFormComponents();
            EnableAllFormComponents();
            
            _currentStairCase = stairCase;

            PopulateStairCaseMetaData(ref stairCase);

            PopulateMeasurementsDropdown(stairCase.MeasuredData);
        }

        private void ClearCurrentStairCase()
        {
            _currentStairCase = null;
            _currentMeasurement = null;
        }

        private void EnableAllFormComponents()
        {
            dropdown_DataChannels.Enabled = true;
            dropdown_Measurements.Enabled = true;
            dropdown_MeasurementFunctions.Enabled = true;
        }

        private void ClearAllFormComponents()
        {
            dropdown_Measurements.Items.Clear();
            dropdown_MeasurementFunctions.SelectedIndex = -1;
        }

        private void PopulateStairCaseMetaData(ref Staircase stairCase)
        {
            var stairCaseMetaData = new string[] { stairCase.StaircaseName, stairCase.StaircaseDescription, stairCase.StaircaseMaterial };
            var stairCaseMetaDataBuilder = new StringBuilder();
            var stairCaseProperties = txtArea_StairCaseMetaData.Lines.Where(l => !string.IsNullOrEmpty(l));

            foreach (var metaData in stairCaseProperties.Zip(stairCaseMetaData, Tuple.Create))
            {
                var metaDataKey = metaData.Item1.Split(':')[0];
                stairCaseMetaDataBuilder.AppendLine(string.Join(": ", metaDataKey, metaData.Item2));
                stairCaseMetaDataBuilder.AppendLine();
            }

            txtArea_StairCaseMetaData.Clear();
            txtArea_StairCaseMetaData.Text = stairCaseMetaDataBuilder.ToString();
        }

        private void PopulateMeasurementsDropdown(List<Measurement> measurements)
        {
            foreach (Measurement m in measurements)
            {
                var stairCaseMeasurementName = string.Join("-", m.Tip, m.Date, m.Description);
                dropdown_Measurements.Items.Add(stairCaseMeasurementName);
            }
        }

        private void PopulateFunctionExpression(int index)
        {
            txtArea_FunctionExpression.Text = _currentMeasurement.FunctionStrings[index];
        }
        
        private void btn_GenerateRegion_Click(object sender, EventArgs e)
        {
            GraphicsAdapter.DrawPolygon(Graphics.FromHwnd(pictureBox_GwyddionImage.Handle), _polygonPoints);
            _regions.Add(_polygonPoints);
            _polygonPoints.Clear();
        }

        private void pictureBox_GwyddionImage_MouseUp(object sender, MouseEventArgs e)
        {
            return;

            if (_currentMeasurement == null)
            {
                MessageBox.Show(StringConstants.ERROR_REGION_SELECTION_NO_MEASUREMENT_DEFINED);
                return;
            }

            var pictureBox = (PictureBox)sender;

            _polygonPoints.Add(new int[] { e.X, e.Y });
            GraphicsAdapter.DrawPoint(Graphics.FromHwnd(pictureBox.Handle), e.X, e.Y);
        }
    }
}