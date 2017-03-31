using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCalc;

namespace SSRMTool.Tests
{
    [TestClass]
    public class StaircaseWhitebox
    {
        [TestMethod]
        public void AddLiterature()
        {
            List<double> rho = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> cm3 = new List<double>(new double[] { 1, 10, 100, 1000 });
            Staircase test = new Staircase(5,"ST3","n-type doped","Si");
            test.DefineSteps(rho, cm3);
            bool type = test.LiteratureResistivity[0].GetType() == typeof(double) && test.LiteratureCarriers[0].GetType() == typeof(double);
            bool length = test.LiteratureResistivity.Count == 4 && test.LiteratureCarriers.Count == 4;
            bool meas = test.Measurements.Count == 0;
            bool metadata = test.StaircaseName == "ST3" && test.StaircaseMaterial == "Si" && test.StaircaseDescription == "n-type doped";
            Assert.IsTrue(type&&length&&meas&&metadata);
        }
        [TestMethod]
        public void AddMeasurement()
        {
            List<double> rho = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> cm3 = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> R = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> dR = new List<double>(new double[] { 1, 10, 100, 1000 });
            Staircase test = new Staircase(5, "ST3", "n-type doped", "Si");
            test.DefineSteps(rho, cm3);
            test.AddMeas("A","B","C",R, dR);
            bool length = test.Measurements.Count == 1;
            bool type = test.Measurements[0].GetType() == typeof(Measurement);
            bool steps_meas = test.Measurements[0].Resistance.Count == 4 && test.Measurements[0].ResistanceAmplitude.Count == 4;
            bool metadata = test.Measurements[0].Tip == "A" && test.Measurements[0].Date == "B" && test.Measurements[0].Description == "C";
            Assert.IsTrue(length&&type&&steps_meas&&metadata);
        }
        [TestMethod]
        public void PopulateFunctions()
        {
            List<double> rho = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> cm3 = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> R = new List<double>(new double[] { 1, 10, 100, 1000 });
            List<double> dR = new List<double>(new double[] { 1, 10, 100, 1000 });
            Staircase test = new Staircase(5, "ST3", "n-type doped", "Si");
            test.DefineSteps(rho, cm3);
            test.AddMeas("", "", "", R, dR);
            test.BuildFunctions(0);
            bool type = test.Measurements[0].Functions.GetType() == typeof(Expression[]);
            bool length = test.Measurements[0].Functions.Length == 4;
            Assert.IsTrue(length && type);
        }

    }
}
