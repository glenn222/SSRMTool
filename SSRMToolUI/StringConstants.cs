using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMToolUI
{
    public static class StringConstants
    {
        private const string FUNCTION_LABEL_1 = "Resistivity vs Resistance(R) Function: ";
        private const string FUNCTION_LABEL_2 = "Resistivity vs Resistance Amplitude (dR) Function: ";
        private const string FUNCTION_LABEL_3 = "Dopants vs Resistance (R) Function: ";
        private const string FUNCTION_LABEL_4 = "Dopants vs Resistance Amplitude (dR) Function: ";
        public const string COMPUTE_STATUS_LABEL = "Compute Status: ";
        public static readonly IList<string> FUNCTION_LABELS =  new List<string> { FUNCTION_LABEL_1, FUNCTION_LABEL_2, FUNCTION_LABEL_3, FUNCTION_LABEL_4 };
        // Unused strings
        private static readonly string RESISTIVITY_UNITS_COLUMN_NAME = "ResistivityUnits";
        private static readonly string DOPANT_UNITS_COLUMN_NAME = "DopantUnits";
        private static readonly string RESISTANCE_UNITS_COLUMN_NAME = "ResistanceUnits";
        private static readonly string RESISTANCE_AMPLITUDE_UNITS_COLUMN_NAME = "ResistanceAmplitudeUnits";

        private static readonly string[] STAIRCASE_TABLE_UNIT_COLUMN_NAMES = new string[]
        {
            RESISTIVITY_UNITS_COLUMN_NAME,
            DOPANT_UNITS_COLUMN_NAME,
            RESISTANCE_UNITS_COLUMN_NAME,
            RESISTANCE_AMPLITUDE_UNITS_COLUMN_NAME
        };

    }
}
