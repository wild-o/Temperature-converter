using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redo
{
    class Class1
    {   // Celsius to Farenheit
        public double CtoF(double value)
        {
            return (value * 9) / 5 + 32;
        }

        // Farenheit to Celsius
        public double FtoC(double value)
        {
            return (value - 32) * 5 / 9;
        }

        // Farenheit to Kelvin
        public double FtoK(double value)
        {
            return (value + 459.67) * 5 / 9;
        }

        //Celsius to Kelvin 
        public double CtoK(double value)
        {
            return (value + 273.15);
        }

        //Kelvin to Farenheit 
        public double KtoF(double value)
        {
            return (value * 9 / 5) - 459.67;
        }

        //Kelvin to Celsius 
        public double KtoC(double value)
        {
            return (value - 273.15);
        }

    }
}
