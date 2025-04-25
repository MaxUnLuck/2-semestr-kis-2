using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticeSulemanov7_2
{
    internal class Calc
    {
        static Calc calc;
        public Calc() { }
        public int radius;
        public bool square;
        public bool lenght;
        public bool sectorArea;
        public string GetAnswer()
        {
            string answer = string.Empty;
            if (square)
            {
                answer += "Square = " + Math.Round(Math.PI * (radius * radius), 2) + Environment.NewLine;
            }
            if (lenght)
            {
                answer += "Lenght = " + Math.Round(2 * Math.PI * radius, 2) + Environment.NewLine;
            }
            if (sectorArea)
            {
                answer += "Sector area = " + Math.Round(0.25 * (Math.PI * (radius * radius)), 2) + Environment.NewLine;
            }
            if (!square && !lenght && !sectorArea)
            {
                answer += "There is nothing to output.";
            }
            return answer;
        }
        public static Calc GetInstance()
        {
            if (calc == null)
            {
                calc = new Calc();
            }
            return calc;
        }
        public bool WindowInput = false;
        public bool WindowCalc  = false;
        public bool WindowAbout = false;
    }
}
