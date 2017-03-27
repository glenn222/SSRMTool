using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSRMToolUI
{
    public partial class OpenStaircaseDataWindow : Form
    {
        private static readonly string STAIRCASE_COLUMN_NAME = "Staircases";
        private static readonly string DATE_CREATED_COLUMN_NAME = "CreationDate";

        private static OpenStaircaseDataWindow _formInstance = null;
        private List<string> _fileNames;
        private List<DateTime> _timeStamps;
        private string _selectedStaircase;

        private OpenStaircaseDataWindow()
        {
            InitializeComponent();

            // Access Redis Database to get a list of staircases
            QueryStaircases();

            // Display all staircases into the data table.
            DisplayNames();
        }

        private void DisplayNames()
        {   
            // TODO:: Display staircase names from DB.
            // Add mock rows
            for (int i = 0; i < 10; i++)
                AddRow("New Staircase Name", "Date Here");
        }

        private void QueryStaircases()
        {
            // TODO:: Connect to Redis database

            // TODO:: Use database manager to get staircase list

            _fileNames = new List<string>(10);
            _timeStamps = new List<DateTime>(10);

            //throw new NotImplementedException();
        }

        private void AddRow(string stairCaseName, string recordDate)
        {
            int index = dataGrdView_StairCaseTable.Rows.Add();
            var row = dataGrdView_StairCaseTable.Rows[index];
            row.Cells[STAIRCASE_COLUMN_NAME].Value = stairCaseName;
            row.Cells[DATE_CREATED_COLUMN_NAME].Value = recordDate;
        }
        
        public static OpenStaircaseDataWindow GetInstance()
        {
            if (_formInstance == null)
                _formInstance = new OpenStaircaseDataWindow();

            return _formInstance;
        }

        private void dataGrdView_StairCaseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataSenderGrid = (DataGridView) sender;

            if (dataSenderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                FindStaircase(e.RowIndex);
            }
        }

        private void FindStaircase(int index)
        {
            var rowData = dataGrdView_StairCaseTable.Rows[index];

            MessageBox.Show(String.Format("You clicked button on row {0}!", index));
            DefineStaircaseWindowForm.PopulateStairCase(rowData);
        }
    }
}
