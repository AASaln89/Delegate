using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate double Delegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Delegate @delegate = Round;
            @delegate += Square;
            @delegate += Volume;
            @delegate(r);
            Console.WriteLine("Для выхода из программы ажмите любую клавишу");
            Console.ReadKey();
        }
        static double Round(double r)
        {
            double L = Math.PI * r * 2;
            Console.WriteLine(L);
            return L;
        }
        static double Square(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            return S;
        }
        static double Volume(double r)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine(V);
            return V;
        }
    }
}
