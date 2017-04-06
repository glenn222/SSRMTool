using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSRMTool;

namespace SSRMToolDB
{
    public class DocumentManager
    {
        private DBManager dbManager;
        public List<Staircase> staircases;
        private Dictionary<String, Staircase> fullStaircaseList;

        public DocumentManager()
        {
            fullStaircaseList = new Dictionary<string, Staircase>();
            dbManager = DBManager.GetInstance();
            staircases = dbManager.Staircases;
            foreach (Staircase st in staircases)
            {
                fullStaircaseList.Add(st.StaircaseName, st);
            }
        }
    
        private void UpdateList()
        {
            fullStaircaseList.Clear();
            staircases = dbManager.Staircases;
            foreach (Staircase st in staircases)
            {
                fullStaircaseList.Add(st.StaircaseName, st);
            }
        }

        public Dictionary<String, DateTime> GetNameTimeList()
        {
            Dictionary<String, DateTime> detailsList = new Dictionary<String, DateTime>();
            foreach (Staircase st in staircases)
            {
                detailsList.Add(st.StaircaseName, st.DateModified);
            }
            return detailsList;
        }

        public Staircase queryStaircase(String name)
        {
            if (fullStaircaseList.ContainsKey(name))
                return fullStaircaseList[name];
            else
                return null;
        }
        
        public void writeStaircase(Staircase obj)
        {
            obj.DateCreated = DateTime.Now;
            obj.DateModified = DateTime.Now;

            dbManager.WriteStaircaseInDB(obj);
            this.UpdateList();
        }

        public void deleteStaircase(Staircase obj)
        {
            dbManager.DeleteStaircaseFromDB(obj);
            this.UpdateList();
        }

    }
}
