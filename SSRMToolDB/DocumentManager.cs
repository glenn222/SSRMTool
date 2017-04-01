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
        private Dictionary<String, Staircase> list;

        public DocumentManager()
        {
            list = new Dictionary<string, Staircase>();
            dbManager = DBManager.GetInstance();
            staircases = dbManager.Staircases;
            foreach (Staircase st in staircases)
            {
                list.Add(st.StaircaseName, st);
            }
        }
    
        private void UpdateList()
        {
            list.Clear();
            staircases = dbManager.Staircases;
            foreach (Staircase st in staircases)
            {
                list.Add(st.StaircaseName, st);
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
            return list[name];
        }
        
        public void writeStaircase(Staircase obj)
        {
            dbManager.ModifyStaircaseInDB(obj);
            this.UpdateList();
        }

        public void addStaircase(Staircase obj)
        {
            dbManager.AddStaircaseInDB(obj);
            this.UpdateList();
        }

        public void deleteStaircase(Staircase obj)
        {
            dbManager.DeleteStaircaseFromDB(obj);
            this.UpdateList();
        }

    }
}
