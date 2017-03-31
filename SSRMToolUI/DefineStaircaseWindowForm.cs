using System;
using System.Text;
using System.Windows.Forms;

namespace SSRMToolUI
{
    public partial class DefineStaircaseWindowForm : Form
    {
        private static DefineStaircaseWindowForm _staircaseInstance = null;
        private static readonly string RESISTIVITY_COLUMN_NAME = "Resistivity";
        private static readonly string RESISTIVITY_UNITS_COLUMN_NAME = "ResistivityUnits";
        private static readonly string DOPANTS_COLUMN_NAME = "Dopants";
        private static readonly string DOPANT_UNITS_COLUMN_NAME = "DopantUnits";
        private static readonly string RESISTANCE_COLUMN_NAME = "Resistance";
        private static readonly string RESISTANCE_UNITS_COLUMN_NAME = "ResistanceUnits";
        private static readonly string RESISTANCE_AMPLITUDE_COLUMN_NAME = "ResistanceAmplitude";
        private static readonly string RESISTANCE_AMPLITUDE_UNITS_COLUMN_NAME = "ResistanceAmplitudeUnits";

        private static readonly string[] STAIRCASE_TABLE_COLUMN_NAMES = new string[]
        {
            RESISTIVITY_COLUMN_NAME,
            DOPANTS_COLUMN_NAME,
            RESISTANCE_COLUMN_NAME,
            RESISTANCE_AMPLITUDE_COLUMN_NAME,
        };

        private static readonly string[] STAIRCASE_TABLE_UNIT_COLUMN_NAMES = new string[]
        {
            RESISTIVITY_UNITS_COLUMN_NAME,
            DOPANT_UNITS_COLUMN_NAME,
            RESISTANCE_UNITS_COLUMN_NAME,
            RESISTANCE_AMPLITUDE_UNITS_COLUMN_NAME
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
            OpenStaircaseDataWindow.GetInstance().Show();
        }

        private void btn_addRow_Click(object sender, EventArgs e)
        {
            //TODO:: Get values from column cells
            var fakeValues = new string[STAIRCASE_TABLE_COLUMN_NAMES.Length];

            for (int i = 0; i < fakeValues.Length; i++)
                fakeValues[i] = "New Value";

            AddRow(fakeValues);
        }

        private void btn_deleteRow_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView_StairCaseMeasurements.RowCount;
            if (rowCount > 1)
                dataGridView_StairCaseMeasurements.Rows.RemoveAt(rowCount - 2);
        }

        // Helper Methods
        private void AddRow(string[] columnValues)
        {        
            int index = dataGridView_StairCaseMeasurements.Rows.Add();
            var row = dataGridView_StairCaseMeasurements.Rows[index];

            for( int i = 0; i < STAIRCASE_TABLE_COLUMN_NAMES.Length; i++ )
            {
                //TODO:: add actual values into table.
                row.Cells[STAIRCASE_TABLE_COLUMN_NAMES[i]].Value = columnValues[i];
            }
        }

        // Populates the staircase values when a user selects a staircase.
        internal static void PopulateStairCase(DataGridViewRow rowData)
        {
            StringBuilder rowBuilder = new StringBuilder();
            foreach( var cell in rowData.Cells )
            {
                rowBuilder.Append(String.Format("Cell: {0} \n", cell));
            }
            
            MessageBox.Show(rowBuilder.ToString());
        }

        private void btn_SaveStairCase_Click(object sender, EventArgs e)
        {
            // TODO:: Get all values from cells and transform it into a single input
            MessageBox.Show("Save Staircase");

            // TODO:: Call DB Manager to store these values
        }
    }
}
