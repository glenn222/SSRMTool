using SSRMTool;
using SSRMToolDB;
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
        private List<String> _fileNames;
        private List<DateTime> _timeStamps;
        private string _selectedStaircase;
        private DocumentManager _documentManager = new DocumentManager();

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
            Dictionary<String, DateTime> nameTimeList = _documentManager.GetNameTimeList();
            
            _fileNames = new List<string>(nameTimeList.Keys);
            _timeStamps = new List<DateTime>(nameTimeList.Values);
            
            // TODO:: Update the data grid table.
            
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
            if (_formInstance == null || _formInstance.IsDisposed == true)
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

            string stairCaseName = _fileNames[index];

            Staircase selectedStaircase = _documentManager.queryStaircase(stairCaseName);
            //TODO:: Find staircase object from DB.
            DefineStaircaseWindowForm.PopulateStairCase(selectedStaircase);
        }
        
        private void Close()
        {
            // Close form, hide x
        }
    }
}
