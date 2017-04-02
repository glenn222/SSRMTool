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
        private int StaircaseID { get; set; }
        public List<double> LiteratureResistivity { get; set; }
        public List<double> LiteratureCarriers { get; set; }
        public string StaircaseName { get; set; }
        public string StaircaseDescription { get; set; }
        public string StaircaseMaterial { get; set; }
        public List<Measurement> MeasuredData { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

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
        public int AddMeas(string tip, string date, string description, List<double> R, List<double> dR)
        {
            if (R.Count==dR.Count && R.Count == LiteratureResistivity.Count)
            {
                Measurement NewMeas = new Measurement(tip, date, description, R, dR);
                MeasuredData.Add(NewMeas);
                return MeasuredData.Count-1;
            }
            else
            {
                return -1;
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

                Measurements[index].FunctionStrings[0] = Staircase.PiecewiseFit(MeasuredData[index].Resistance, LiteratureResistivity);
                Measurements[index].FunctionStrings[1] = Staircase.PiecewiseFit(MeasuredData[index].Resistance, LiteratureCarriers);
                Measurements[index].FunctionStrings[2] = Staircase.PiecewiseFit(MeasuredData[index].ResistanceAmplitude, LiteratureResistivity);
                Measurements[index].FunctionStrings[3] = Staircase.PiecewiseFit(MeasuredData[index].ResistanceAmplitude, LiteratureCarriers);
                
                for ( int i = 0; i < Measurements[index].FunctionStrings.Length; i++)
                    MeasuredData[index].Functions[i] = new Expression(Measurements[index].FunctionStrings[i]);
                
            }
        }
        public static string PiecewiseFit(List<double> independent, List<double> dependent, string var="[x]", string tc="1e12", string step="(2/3.14159265359)*Atan", string exp="Exp")
        {
            //Sort and check length matching
            if (dependent.Count != independent.Count)
            {
                return "";
            }
            SortedDictionary<double, double> sorted = new SortedDictionary<double, double>();
            for (int i = 0; i < dependent.Count; i++)
            {
                //if both independent and dependent variables are specified, add to the list
                //the dependent variable is analyzed on a log scale and thus cannot equal zero
                if (independent[i]!=Double.NaN && dependent[i] != Double.NaN && dependent[i]!=0 && !sorted.ContainsKey(independent[i]))
                {
                    //add value to sorted list with dependent variable only positive
                    sorted.Add(independent[i], Math.Abs(dependent[i]));
                }              
            }
            if (sorted.Count == 0)
            {
                return "1+0*"+var;
            }
            if (sorted.Count == 1)
            {
                return sorted.ElementAt(0).Value.ToString()+"+0*"+var;
            }
            //function string
            string fstring = "";
            //Temporary values for iterations
            double Y1, Y2, X1, X2, M, B;
            string piece_function, step_function; 
            for (int i = 0; i < sorted.Count-1; i++)
            {

                Y1 = Math.Log(sorted.ElementAt(i).Value);
                Y2 = Math.Log(sorted.ElementAt(i+1).Value);
                X1 = sorted.ElementAt(i).Key;
                X2 = sorted.ElementAt(i+1).Key;
                M = (Y2 - Y1) / (X2 - X1);
                B = Y1 - X1 * M;
                piece_function = exp+"(" + M.ToString() + "*" + var + "+(" + B.ToString() + "))";
                if (sorted.Count == 2)
                {
                    fstring = piece_function;
                    break;
                }
                if (i == 0)
                {
                    step_function = "0.5*(1+" + step + "(-" + tc + "*(" + var + "-(" + X2.ToString() + "))))";
                    fstring += piece_function + "*" + step_function;
                }
                else
                {
                    if (i < sorted.Count - 2)
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
