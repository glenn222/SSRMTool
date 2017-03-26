using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Add mock rows
            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");

            AddRow("New Staircase Name", "Date Here");
        }

        private void QueryStaircases()
        {
            // TODO:: Connect to Redis database

            // TODO:: Use datbase manager to get staircase list

            _fileNames = new List<String>(10);
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
    }
}
