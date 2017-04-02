using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSRMTool;
using System.Collections.Generic;

namespace SSRMToolDB.Tests
{
    [TestClass]
    public class DBManagerUnitTests
    {
        [TestMethod]
        public void AddStaircaseToDB()
        {
            
            var dbManager = new DocumentManager();
            var stairCase = new Staircase(1, "ST3", "A Staircase", "Silicon");
            List<Double> rho = new List<double>();
            List<Double> cm3 = new List<double>();

            rho.AddRange(new double[] {0.000537, 0.000997, 0.001191, 0.002554, 0.003709 });
            cm3.AddRange(new double[] {7790000, 2900000, 2000000, 500000, 270000 });

            stairCase.DefineSteps(rho, cm3);

            List <Double> R = new List<double>();
            List<Double> dR = new List<double>();

            R.AddRange(new double[] {-2.51, -2.38, -2.02, -1.77, -1.11});
            dR.AddRange(new double[] {-3.22, -3.08, -2.8, -2.66, 1.7});

            int index = stairCase.AddMeas("2015.03.10", DateTime.Now.ToString(), "Test 1", R, dR);
            stairCase.BuildFunctions(index);
            
            dbManager.writeStaircase(stairCase);

            var dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);

            Assert.AreEqual(stairCase.StaircaseName, dbStaircase.StaircaseName);

            Assert.IsTrue(dbManager.staircases.Contains(dbStaircase));
        }

        [TestMethod]
        public void ModifyStaircaseinDB()
        {

            var dbManager = new DocumentManager();
            var stairCase = new Staircase(1, "Gb269", "G2N Lab test", "Gallium");
            List<Double> rho = new List<double>();
            List<Double> cm3 = new List<double>();

            rho.AddRange(new double[] { 0.000537, 0.000997, 0.001191, 0.002554, 0.003709 });
            cm3.AddRange(new double[] { 7790000, 2900000, 2000000, 500000, 270000 });

            stairCase.DefineSteps(rho, cm3);

            List<Double> R = new List<double>();
            List<Double> dR = new List<double>();

            R.AddRange(new double[] { -2.51, -2.38, -2.02, -1.77, -1.11 });
            dR.AddRange(new double[] { -3.22, -3.08, -2.8, -2.66, 1.7 });

            int index = stairCase.AddMeas("2015.09.10", DateTime.Now.ToString(), "Test 2", R, dR);
            stairCase.BuildFunctions(index);

            // First add a staircase to DB, retrieve it and make sure its there in the DB
            dbManager.writeStaircase(stairCase);

            var dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);

            Assert.AreEqual(stairCase.StaircaseName, dbStaircase.StaircaseName);

            Assert.IsTrue(dbManager.staircases.Contains(dbStaircase));

            //Now modify staircase
            R.Clear();
            R.AddRange(new double[] { -2.78, -2.26, -2.34, -1.9, -1.02 });
            dR.Clear();
            dR.AddRange(new double[] { -3.22, -3.08, -2.8, -2.66, 1.7 });

            index = stairCase.AddMeas("2015.10.10", DateTime.Now.ToString(), "Test 3", R, dR);
            stairCase.BuildFunctions(index);

            //Write the staircase to the DB again. 
            dbManager.writeStaircase(stairCase);

            dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);

            //Check if that staircase was modified

            Assert.AreEqual(stairCase.StaircaseName, dbStaircase.StaircaseName);

            Assert.AreEqual(stairCase.MeasuredData.Count, dbStaircase.MeasuredData.Count);

            Assert.IsTrue(dbManager.staircases.Contains(dbStaircase));
        }

        [TestMethod]
        public void DeleteStaircaseFromDB()
        {

            var dbManager = new DocumentManager();
            var stairCase = new Staircase(1, "MJ5", "A Staircase", "Arsenic");
            List<Double> rho = new List<double>();
            List<Double> cm3 = new List<double>();

            rho.AddRange(new double[] { 0.000537, 0.000997, 0.001191, 0.002554, 0.003709});
            cm3.AddRange(new double[] { 7790000, 2900000, 2000000, 500000, 270000});

            stairCase.DefineSteps(rho, cm3);

            // Add Staircase to DB

            dbManager.writeStaircase(stairCase);

            var dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);

            Assert.AreEqual(stairCase.StaircaseName, dbStaircase.StaircaseName);

            Assert.IsTrue(dbManager.staircases.Contains(dbStaircase));

            //Remove Staircase from DB
            dbManager.deleteStaircase(stairCase);
            dbStaircase = dbManager.queryStaircase(stairCase.StaircaseName);
            Assert.AreEqual(dbStaircase, null);
            Assert.IsFalse(dbManager.staircases.Contains(stairCase));
        }

    }
}
