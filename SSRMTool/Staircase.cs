using System;
using NCalc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    public class Staircase
    {
        //Member objects defining staircase
        private int StaircaseID;
        public List<double> LiteratureResistivity;
        public List<double> LiteratureCarriers;
        public string StaircaseName;
        public string StaircaseDescription;
        public string StaircaseMaterial;
        public List<Measurement> MeasuredData;
        public DateTime DateCreated;
        public DateTime DateModified;

        //Constructor
        public Staircase(int id, string name, string description, string material)
        {
            StaircaseID = id;
            StaircaseName = name;
            StaircaseDescription = description;
            StaircaseMaterial = material;
            MeasuredData = new List<Measurement>();
        }
        //Set members
        public bool DefineSteps(List<double> rho, List<double> cm3)
        {
            if ((rho.Count != cm3.Count) || rho.Count==0 || cm3.Count == 0)
            {
                //Do not set with unequal sets or empty sets
                return false;
            }
            else
            {
                //Replace existing literature sets
                LiteratureResistivity = rho;
                LiteratureCarriers = cm3;
                return true;
            }
        }
        public List<Measurement> Measurements
        {
            get
            {
                return this.MeasuredData;
            }
            set
            {
                this.MeasuredData = value;
            }
        }
        public bool AddMeas(string tip, string date, string description, List<double> R, List<double> dR)
        {
            if (R.Count==dR.Count && R.Count == LiteratureResistivity.Count)
            {
                Measurement NewMeas = new Measurement(tip, date, description, R, dR);
                MeasuredData.Add(NewMeas);
                return true;
            }
            else
            {
                return false;
            }
        }
        //Create fit functions
        public void BuildFunctions(int index)
        {
            if (index > MeasuredData.Count)
            {
                //Invalid index
            }
            else
            {
                MeasuredData[index].Functions[0] = new Expression(Staircase.PiecewiseFit(MeasuredData[index].Resistance, LiteratureResistivity));
                MeasuredData[index].Functions[1] = new Expression(Staircase.PiecewiseFit(MeasuredData[index].Resistance, LiteratureCarriers));
                MeasuredData[index].Functions[2] = new Expression(Staircase.PiecewiseFit(MeasuredData[index].ResistanceAmplitude, LiteratureResistivity));
                MeasuredData[index].Functions[3] = new Expression(Staircase.PiecewiseFit(MeasuredData[index].ResistanceAmplitude, LiteratureCarriers));
            }
        }
        public static string PiecewiseFit(List<double> independent, List<double> dependent, string var="[x]", string tc="1e6", string step="(2/3.14159265359)*Atan", string exp="Exp")
        {
            //Sort and check length matching
            //function string
            string fstring = "";
            //Temporary values for iterations
            double Y1, Y2, X1, X2, M, B;
            string piece_function, step_function; 
            for (int i = 0; i < dependent.Count-1; i++)
            {
                Y1 = Math.Log(dependent[i]);
                Y2 = Math.Log(dependent[i + 1]);
                X1 = independent[i];
                X2 = independent[i + 1];
                M = (Y2 - Y1) / (X2 - X1);
                B = Y1 - X1 * M;
                piece_function = exp+"(" + M.ToString() + "*" + var + "+(" + B.ToString() + "))";
                if (i == 0)
                {
                    step_function = "0.5*(1+" + step + "(-" + tc + "*(" + var + "-(" + X2.ToString() + "))))";
                    fstring += piece_function + "*" + step_function;
                }
                else
                {
                    if (i < dependent.Count - 2)
                    {
                        step_function = "0.5*(" + step + "(" + tc + "*(" + var + "-(" + X1.ToString() + ")))-" + step + "(" + tc + "*(" + var + "-(" + X2.ToString() + "))))";
                    }
                    else
                    {
                        step_function = "0.5*(1+" + step + "(" + tc + "*(" + var + "-(" + X1.ToString() + "))))";
                    }
                    fstring += "+"+piece_function + "*" + step_function;
                }
            }
            return fstring;
        }
    }
}
