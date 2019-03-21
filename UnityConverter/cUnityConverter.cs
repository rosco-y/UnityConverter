
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityConverter
{
    // It's assumed that 1 unit in UNITY is 1 meter.

    public static class cUnityConverter
    {
        static float FeetToMeters(float feet)
        {
            return feet / cConversionFactors.MetersToFeet;
        }

        static float InchesToMeters(float inches)
        {
            return inches / cConversionFactors.MetersToInches;
        }

        static float MilesToMeters(float miles)
        {
            return miles * cConversionFactors.MilesToMeters;
        }
    }
}
