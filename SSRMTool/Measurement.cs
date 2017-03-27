using System;
using NCalc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    public class Measurement
    {
        public int ID;
        public string Tip;
        public string Date;
        public string Description;
        public Expression[] Functions;
        public List<double> Resistance;
        public List<double> ResistanceAmplitude;

        public Measurement(string tip, string date, string description, List<double> R, List<double> dR)
        {
            Tip = tip;
            Date = date;
            Description = description;
            Resistance = R;
            ResistanceAmplitude = dR;
            Functions = new Expression[4];
        }
    }
}
