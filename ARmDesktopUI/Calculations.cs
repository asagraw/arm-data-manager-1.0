using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARmDesktopUI
{
    public class Calculations : ICalculations
    {
        public List<string> register { get; set; } = new List<string>();

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
