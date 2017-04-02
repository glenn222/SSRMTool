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
        private static readonly string DATE_MODIFIED_COLUMN_NAME = "ModifiedDate";

        private static OpenStaircaseDataWindow _formInstance = null;
        private IList<String> _stairCaseNames;
        private IList<DateTime> _timeStamps;
        private Staircase _selectedStaircase;
        private DocumentManager _documentManager;
        private Form _requestForm;

        private OpenStaircaseDataWindow(Form requestForm)
        {
            InitializeComponent();

            if (requestForm.Name.Equals("QuantifyDeviceWindow"))
                _requestForm = (QuantifyDeviceWindow) requestForm;
            else if (requestForm.Name.Equals("DefineStaircaseWindowForm"))
                _requestForm = (DefineStaircaseWindowForm) requestForm;

            // Access Redis Database to get a list of staircases
            QueryStaircases();

            // Display all staircases into the data table.
            DisplayStairCases();
        }

        private void dataGrdView_StairCaseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataSenderGrid = (DataGridView)sender;

            if (dataSenderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var stairCase = FindStaircase(e.RowIndex);

                if (_requestForm is DefineStaircaseWindowForm)
                {
                    DefineStaircaseWindowForm.GetStairCaseInstance().PopulateStairCase(stairCase);
                    TransitionToDefineStairCaseWindow();
                }
                else if (_requestForm is QuantifyDeviceWindow)
                {
                    QuantifyDeviceWindow.GetQuantifyDeviceInstance().PopulateStairCase(stairCase);
                    TransitionToQuantifyDeviceWindow();
                }
                
            }
        }

        public static OpenStaircaseDataWindow GetInstance(Form requestForm)
        {
            if (_formInstance == null || _formInstance.IsDisposed == true)
                _formInstance = new OpenStaircaseDataWindow(requestForm);

            return _formInstance;
        }
        
        private void DisplayStairCases()
        {
            for (int i = 0; i < _stairCaseNames.Count; i++)
                AddRow(_stairCaseNames[i], _timeStamps[i].ToString());
        }

        private void QueryStaircases()
        {
            _documentManager = new DocumentManager();
            Dictionary<String, DateTime> nameTimeList = _documentManager.GetNameTimeList();

            _stairCaseNames = new List<string>(nameTimeList.Keys);
            _timeStamps = new List<DateTime>(nameTimeList.Values);
        }

        private void AddRow(string stairCaseName, string recordDate)
        {
            int index = dataGrdView_StairCaseTable.Rows.Add();
            var row = dataGrdView_StairCaseTable.Rows[index];

            row.Cells[STAIRCASE_COLUMN_NAME].Value = stairCaseName;
            row.Cells[DATE_MODIFIED_COLUMN_NAME].Value = recordDate;
        }

        private Staircase FindStaircase(int index)
        {
            var rowData = dataGrdView_StairCaseTable.Rows[index];

            string stairCaseName = _stairCaseNames[index];

            _selectedStaircase = _documentManager.queryStaircase(stairCaseName);

            return _selectedStaircase;
        }

        private void TransitionToDefineStairCaseWindow()
        {
            this.Dispose();
            DefineStaircaseWindowForm.GetStairCaseInstance().Show();
        }

        private void TransitionToQuantifyDeviceWindow()
        {
            this.Dispose();
            QuantifyDeviceWindow.GetQuantifyDeviceInstance().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            TransitionToDefineStairCaseWindow();
        }

    }
}
