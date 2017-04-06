using SSRMTool;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SSRMToolDB;
using System.Globalization;

namespace SSRMToolUI
{
    public partial class DefineStaircaseWindowForm : Form
    {
        private static DefineStaircaseWindowForm _staircaseInstance = null;
        private string[] _functions;
        private Staircase _currentStairCase;
        private StringBuilder _textAreaOutputLogger = new StringBuilder();
        private bool _isExistingMeasurement = false;
        private int _measurementIndex;

        private static readonly string RESISTIVITY_COLUMN_NAME = "Resistivity";
        private static readonly string DOPANTS_COLUMN_NAME = "Dopants";
        private static readonly string RESISTANCE_COLUMN_NAME = "Resistance";
        private static readonly string RESISTANCE_AMPLITUDE_COLUMN_NAME = "ResistanceAmplitude";

        private static readonly string[] STAIRCASE_TABLE_COLUMN_NAMES = new string[]
        {
            RESISTIVITY_COLUMN_NAME,
            DOPANTS_COLUMN_NAME,
            RESISTANCE_COLUMN_NAME,
            RESISTANCE_AMPLITUDE_COLUMN_NAME,
        };
        
        private DefineStaircaseWindowForm()
        {
            InitializeComponent();
        }

        public static DefineStaircaseWindowForm GetStairCaseInstance()
        {
            if (_staircaseInstance == null || _staircaseInstance.IsDisposed == true)
                _staircaseInstance = new DefineStaircaseWindowForm();

            return _staircaseInstance;
        }

        private void btn_OpenStaircases_Click(object sender, EventArgs e)
        {
            Hide();
            OpenStaircaseDataWindow.GetInstance(this).Show();
        }

        private void btn_addRow_Click(object sender, EventArgs e)
        {
            var defaultRowValues = new List<string>(STAIRCASE_TABLE_COLUMN_NAMES.Length);

            for (int i = 0; i < defaultRowValues.Capacity; i++)
                defaultRowValues.Add("1"); //String.Empty;

            AddRow(defaultRowValues);

            ToggleComputeStairCaseButton();
        }

        private void btn_deleteRow_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView_StairCaseMeasurements.RowCount;
            if (rowCount > 0)
                dataGridView_StairCaseMeasurements.Rows.RemoveAt(rowCount - 1);

            ToggleComputeStairCaseButton();
        }

        private void btn_SaveStairCase_Click(object sender, EventArgs e)
        {
            var docManager = new DocumentManager();
            docManager.writeStaircase(_currentStairCase);

            _textAreaOutputLogger.AppendLine("Staircase Saved");
            TxtArea_StairCaseOutput.Text += _textAreaOutputLogger.ToString();
            btn_SaveStairCase.Enabled = false;
        }

        private void btn_ComputeStaircase_Click(object sender, EventArgs e)
        {
            if (txtField_StairCaseName.Text.Equals(string.Empty) || txtField_StairCaseName.Text == null) {
                MessageBox.Show("Please enter a name for the staircase");
                return;
            }

            Staircase stairCase;

            if (_currentStairCase != null)
            {
                stairCase = _currentStairCase;
                UpdateStairCaseFromInputs(ref stairCase);
            }
            else
                stairCase = CreateStaircaseFromInputs();

            bool isStairCaseDefined = DefineStaircase(ref stairCase);

            TxtArea_StairCaseOutput.Clear();

            if (isStairCaseDefined)
            {
                btn_SaveStairCase.Enabled = true;
                _currentStairCase = stairCase;
                _textAreaOutputLogger.AppendLine(StringConstants.COMPUTE_STATUS_LABEL + "Success");
                UpdateFunctionLabels();
            }
            else
                _textAreaOutputLogger.AppendLine(StringConstants.COMPUTE_STATUS_LABEL + "Failed");
        }

        private void UpdateStairCaseFromInputs(ref Staircase stairCase)
        {
            stairCase.StaircaseDescription = txtField_StairCaseDescription.Text;
            stairCase.StaircaseName = txtField_StairCaseName.Text;
            stairCase.StaircaseMaterial = txtField_StaircaseMaterial.Text;
            stairCase.MeasuredData[_measurementIndex].Tip = txtField_TipName.Text;
            stairCase.MeasuredData[_measurementIndex].Description = txtField_MeasurementDescription.Text;
        }

        private void dropdown_StairCaseMeasurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            var measurementComboBox = (ComboBox) sender;

            int measurementIndex = measurementComboBox.SelectedIndex;

            if (measurementIndex > 0)
            {
                var selectedMeasurement = _currentStairCase.MeasuredData[measurementIndex - 1];

                UpdateFormWithMeasurement(selectedMeasurement);
                _measurementIndex = measurementIndex - 1;
            }
            else
            {
                CreateNewMeasurement();
            }

            ToggleComputeStairCaseButton();
        }

        public void PopulateStairCase(Staircase stairCase)
        {
            ToggleComputeStairCaseButton();
            ClearAllStaircaseFormComponents();
            TxtArea_StairCaseOutput.Clear();

            _currentStairCase = stairCase;

            var rowData = new List<string>();

            for (int i = 0; i < stairCase.LiteratureResistivity.Count; i++)
            {
                rowData.Add(stairCase.LiteratureResistivity[i].ToString());
                rowData.Add(stairCase.LiteratureCarriers[i].ToString());
                // rowData.Add(stairCase.Measurements[0].Resistance[i].ToString());
                // rowData.Add(stairCase.Measurements[0].ResistanceAmplitude[i].ToString());
                AddRow(rowData);
                rowData.Clear();
            }

            txtField_StairCaseName.Text = stairCase.StaircaseName;
            txtField_StairCaseDescription.Text = stairCase.StaircaseDescription;
            txtField_StaircaseMaterial.Text = stairCase.StaircaseMaterial;

            dropdown_StairCaseMeasurements.Items.Clear();
            dropdown_StairCaseMeasurements.Items.Add("New Measurement");
            foreach (Measurement m in stairCase.Measurements)
            {
                var stairCaseMeasurementName = string.Join("-", m.Tip, m.Date, m.Description);
                dropdown_StairCaseMeasurements.Items.Add(stairCaseMeasurementName);
            }

            // Default select "New Measurement"
            dropdown_StairCaseMeasurements.SelectedItem = dropdown_StairCaseMeasurements.Items[0];
        }

        private bool DefineStaircase(ref Staircase stairCase)
        {
            var stairCaseTableRows = dataGridView_StairCaseMeasurements.Rows;

            var rhoValues = new List<double>();
            var dopantValues = new List<double>();
            var resistanceValues = new List<double>();
            var resistanceAmplitudeValues = new List<double>();

            foreach (DataGridViewRow row in stairCaseTableRows)
            {
                for (int i = 0; i < STAIRCASE_TABLE_COLUMN_NAMES.Length; i++)
                {
                    string rhoValue = row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i]].Value.ToString();
                    string dopantValue = row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i + 1]].Value.ToString();
                    string resistanceValue = row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i + 2]].Value.ToString();
                    string resistanceAmplitudeValue = row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i + 3]].Value.ToString();

                    try
                    {
                        rhoValues.Add(Double.Parse(rhoValue));
                        dopantValues.Add(Double.Parse(dopantValue));
                        resistanceValues.Add(Double.Parse(resistanceValue));
                        resistanceAmplitudeValues.Add(Double.Parse(resistanceAmplitudeValue));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return false;
                    }

                    break;
                }
            }

            var isDefined = stairCase.DefineSteps(rhoValues, dopantValues);

            if (isDefined)
            {
                var measurementDescription = txtField_MeasurementDescription.Text;
                var measurementTip = txtField_TipName.Text;

                if (!_isExistingMeasurement)
                {
                    // Add New Measurement to Staircase
                    int index = stairCase.AddMeas(measurementTip, new DateTime().ToString(), measurementDescription, resistanceValues, resistanceAmplitudeValues);
                    stairCase.BuildFunctions(index);
                    _functions = stairCase.Measurements[index].FunctionStrings;
                }
                else
                {
                    // Overwrite existing measurement
                    stairCase.Measurements[_measurementIndex].Resistance = resistanceValues;
                    stairCase.Measurements[_measurementIndex].ResistanceAmplitude = resistanceAmplitudeValues;
                    stairCase.BuildFunctions(_measurementIndex);

                    _functions = stairCase.Measurements[_measurementIndex].FunctionStrings;
                }
            }

            // Define Staircase steps
            return isDefined;
        }

        private Measurement CreateMeasurementFromInputs(ref List<double> R, ref List<double> dR)
        {
            var measurementDescription = txtField_MeasurementDescription.Text;
            var measurementTip = txtField_TipName.Text;

            return new Measurement(measurementTip, measurementDescription, new DateTime().ToString(), R, dR);
        }

        private Staircase CreateStaircaseFromInputs()
        {
            var stairCaseDescription = txtField_StairCaseDescription.Text;
            var stairCaseName = txtField_StairCaseName.Text;
            var stairCaseMaterial = txtField_StaircaseMaterial.Text;
            int id = 1;

            return new Staircase(id, stairCaseName, stairCaseDescription, stairCaseMaterial);
        }

        // Helper Methods
        private void UpdateFormWithMeasurement(Measurement selectedMeasurement)
        {
            int index = 0;

            foreach (DataGridViewRow row in dataGridView_StairCaseMeasurements.Rows)
            {
                row.Cells[RESISTANCE_COLUMN_NAME].Value = selectedMeasurement.Resistance[index];
                row.Cells[RESISTANCE_AMPLITUDE_COLUMN_NAME].Value = selectedMeasurement.ResistanceAmplitude[index];
                index++;
            }

            txtField_TipName.Text = selectedMeasurement.Tip;
            txtField_MeasurementDescription.Text = selectedMeasurement.Description;

            _functions = selectedMeasurement.FunctionStrings;
            UpdateFunctionLabels();

            _isExistingMeasurement = true;
        }

        private void CreateNewMeasurement()
        {
            TxtArea_StairCaseOutput.Clear();
            txtField_TipName.Clear();
            txtField_MeasurementDescription.Clear();

            foreach (DataGridViewRow row in dataGridView_StairCaseMeasurements.Rows)
            {
                row.Cells[RESISTANCE_COLUMN_NAME].Value = string.Empty;
                row.Cells[RESISTANCE_AMPLITUDE_COLUMN_NAME].Value = string.Empty;
            }

            _isExistingMeasurement = false;
        }

        private void UpdateFunctionLabels()
        {
            if (_functions == null)
            {
                _textAreaOutputLogger.Clear();
                return;
            }

            for ( int i = 0; i < StringConstants.FUNCTION_LABELS.Count; i++)
            {
                _textAreaOutputLogger.AppendLine();
                _textAreaOutputLogger.AppendLine(string.Join("\n", StringConstants.FUNCTION_LABELS[i], _functions[i]));
            }

            TxtArea_StairCaseOutput.Text = _textAreaOutputLogger.ToString();

            _textAreaOutputLogger.Clear();
        }

        private void AddRow<T>(List<T> rowValues)
        {
            int index = dataGridView_StairCaseMeasurements.Rows.Add();
            var row = dataGridView_StairCaseMeasurements.Rows[index];
            
            for (int i = 0; i < rowValues.Count; i++)
            {
                row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i]].Value = rowValues[i];
            }
        }

        // UI Behaviours
        private void DisableAllFormComponents()
        {
            DisableAllTextFieldComponents();
            DisableAllButtons();
        }

        private void DisableAllTextFieldComponents()
        {
            txtField_StairCaseName.Enabled = false;
            txtField_StairCaseDescription.Enabled = false;
            txtField_MeasurementDescription.Enabled = false;
        }
    
        private void DisableAllButtons()
        {
            btn_addRow.Enabled = false;
            btn_deleteRow.Enabled = false;
        }

        private void EnableAllFormComponents()
        {
            dataGridView_StairCaseMeasurements.Enabled = true;
            txtField_StairCaseName.Enabled = true;
            txtField_StairCaseDescription.Enabled = true;
            txtField_MeasurementDescription.Enabled = true;
            btn_addRow.Enabled = true;
            btn_deleteRow.Enabled = true;
        }
        
        private void ClearAllStaircaseFormComponents()
        {
            dataGridView_StairCaseMeasurements.Rows.Clear();
            dropdown_StairCaseMeasurements.Items.Clear();
            txtField_StairCaseName.Clear();
            txtField_StairCaseDescription.Clear();
            txtField_StaircaseMaterial.Clear();
        }
        
        private void ToggleComputeStairCaseButton()
        {
            // Enable compute button only if two rows are in table
            btn_ComputeStaircase.Enabled = (dataGridView_StairCaseMeasurements.Rows.Count >= 2 && dropdown_StairCaseMeasurements.SelectedIndex >= 0) ? true : false;
        }

        private void dataGridView_StairCaseMeasurements_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = dataGridView_StairCaseMeasurements[e.ColumnIndex, e.RowIndex].Value.ToString();

            double formattedCellValue;
            bool parsingSuccess = Double.TryParse(cellValue, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out formattedCellValue);

            if (parsingSuccess)
                dataGridView_StairCaseMeasurements[e.ColumnIndex, e.RowIndex].Value = formattedCellValue;
            else
                dataGridView_StairCaseMeasurements[e.ColumnIndex, e.RowIndex].Value = string.Empty;
        }
    }
}