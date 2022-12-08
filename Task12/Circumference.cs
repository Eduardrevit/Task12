using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    static class Circumference
    {
        static public double GetLenth(double r)
        {
            return 2 * r * Math.PI;
        }
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public string GetCheck(double r, double x0, double y0, double x, double y)
        {
            double a = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
            if (a<=r)
                return "Точка принадлежит окружности";
            else
                return "Точка НЕ принадлежит окружности";
        }

    }
}
