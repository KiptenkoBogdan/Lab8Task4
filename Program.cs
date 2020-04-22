using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task4
{
    class Program
    {
        delegate double Operation(double x);
        static void Main(string[] args)
        {
            Operation op;
            string symbol;
            Function f = new Function();
            Dictionary<String, Operation> dict = new Dictionary<string, Operation>();
            Console.Write("Input x : ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("1. x + 2x^2 + 4");
            Console.WriteLine("2. x + x^2 + x^3");
            Console.WriteLine("3. x + 2x + 3x");

            Console.WriteLine("\tDelegate");
            op = f.Func1;
            Console.WriteLine("Func1: " + f.Func1(x));
            op = f.Func2;
            Console.WriteLine("Func2: " + f.Func2(x));
            op = f.Func3;
            Console.WriteLine("Func3: " + f.Func3(x));

            dict["1"] = (r) => f.Func1(x);
            dict["2"] = (r) => f.Func2(x);
            dict["3"] = (r) => f.Func3(x);

            Console.WriteLine("Choose function");
            symbol = Console.ReadLine();
            Console.WriteLine("\tDictionary");
            Console.WriteLine("Result: " + dict[symbol](x));

            Console.ReadKey();
        }
    }
}
