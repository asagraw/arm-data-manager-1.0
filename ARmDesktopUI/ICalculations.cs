using System.Collections.Generic;

namespace ARmDesktopUI
{
    public interface ICalculations
    {
        List<string> register { get; set; }

        double Add(double x, double y);
    }
}