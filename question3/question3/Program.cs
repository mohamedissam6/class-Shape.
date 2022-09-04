using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shap1 = new Shape(5, 10);
            Shape shap2 = new Shape(10, 5);
            Shape shap3 = shap1 + shap2;
            Console.WriteLine("{0}\t{1}\n{2}\t{3}\n{4}\t{5}",shap1.Length, shap1.Width,shap2.Length,shap2.Width,shap3.Length,shap3.Width);
            Console.WriteLine(shap3.Check());
            Console.ReadLine();
             
            

        }
    }
}
