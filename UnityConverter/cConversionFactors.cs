using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConverter
{
    public static class cConversionFactors
    {
        // 3.28084 feet in 1 meter.
        public static float MetersToFeet = 1 / 3.28084f;

        // 39.37008 inches in 1 meter.
        public static float MetersToInches = 1 / 39.37008f;

        // 1609.34 meters per mile
        public static float MilesToMeters = 1609.34f;

    }
}
