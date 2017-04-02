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
        public int ID { get; set; }
        public string Tip { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public Expression[] Functions { get; set; }
        public string[] FunctionStrings { get; set; }
        public List<double> Resistance { get; set; }
        public List<double> ResistanceAmplitude { get; set; }

        public Measurement(string tip, string date, string description, List<double> R, List<double> dR)
        {
            Tip = tip;
            Date = date;
            Description = description;
            Resistance = R;
            ResistanceAmplitude = dR;
            Functions = new Expression[4];
            FunctionStrings = new string[4];
        }
        public void PopulateExpressions()
        {
            for (int i = 0; i < 4; i++)
            {
                Functions[i] = new Expression(FunctionStrings[i]);
            }
        }

    }
}
