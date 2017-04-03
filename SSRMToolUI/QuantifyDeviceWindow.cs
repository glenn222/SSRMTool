using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSRMTool;

namespace SSRMToolUI
{
    public partial class QuantifyDeviceWindow : Form
    {
        private static QuantifyDeviceWindow _quantifyDeviceWindow = null;
        private Staircase _currentStairCase;
        private Measurement _currentMeasurement;
        private static readonly string FILE_DIALOG_JPG_FILTER = "JPEG File|*.jpg";
        private static readonly string FILE_DIALOG_FILTER = "Gwyddion File|*.gwy";
        
        private QuantifyDeviceWindow()
        {
            InitializeComponent();
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
                if (dialog.FileName != string.Empty && dialog.FileName != null)
                {
                    txtArea_GwyFilePath.Text = dialog.FileName;

                    //TODO:: Get gwyddion image data and create bitmap with it.

                    //// Create fake bitmap values
                    //double[,] bitMapValues = CreateFakeBitmapValues(1000, 1000);

                    //// Create bitmap using array of doubles
                    //pictureBox_GwyddionImage.Image = BitmapMaker.CreateBitMap(bitMapValues);
                }
            }
        }

        private double[,] CreateFakeBitmapValues(int width, int height)
        {
            var rand = new Random();

            double[,] bitMapValues = new double[width, height];
            for (int i = 0; i < bitMapValues.GetLength(0); i++)
            {
                for (int j = 0; j < bitMapValues.GetLength(1); j++)
                {
                    bitMapValues[i, j] = rand.NextDouble();
                }
            }

            return bitMapValues;
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
            }
        }
        
        private void dropdown_DataChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataChannelComboBox = (ComboBox) sender;
            MessageBox.Show("Data Channel Selected " + dataChannelComboBox.SelectedIndex);
            DeviceManager devManager = new DeviceManager();
            Bitmap image = devManager.GetChannelImage(" ", 3);
            pictureBox_GwyddionImage.Image = image;

            // TODO:: Get image for that certain data channel.
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculate");
            // TODO:: Get Apply Function Expression on displayed gwyddion image.
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
        }

        private void PopulateStairCaseMetaData(ref Staircase stairCase)
        {
            var stairCaseMetaData = new string[] { stairCase.StaircaseName, stairCase.StaircaseDescription, stairCase.StaircaseMaterial };
            var stairCaseMetaDataBuilder = new StringBuilder();
            
            foreach (var metaData in txtArea_StairCaseMetaData.Lines.Zip(stairCaseMetaData, Tuple.Create))
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
        
    }
}