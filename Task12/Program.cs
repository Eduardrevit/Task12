using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности r=");
            double r = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите координату центра окружности x0=");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату центра окружности y0=");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату проверяемой точки x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты проверяемой точки y=");
            double y = Convert.ToDouble(Console.ReadLine());

            double square = Circumference.GetSquare(r);
            string point = Circumference.GetCheck(r, x0, y0, x, y);

            Console.WriteLine($"Площадь круга = {square:.00}. {point}");
            Console.ReadKey();
        }
    }
}
