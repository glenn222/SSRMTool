using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSRMTool;

namespace SSRMToolDB.Tests
{
    [TestClass]
    public class DBManagerUnitTests
    {
        [TestMethod]
        public void Add_Staircase_Object()
        {
            
            var dbManager = new DocumentManager();
            var stairCase = new Staircase(1, "StaircaseName", "A Staircase", "Some Material");
            
            dbManager.addStaircase(stairCase);

            var dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);

            Assert.AreEqual(stairCase.StaircaseName, dbStaircase.StaircaseName);

            Assert.IsTrue(dbManager.staircases.Contains(dbStaircase));
        }


    }
}
