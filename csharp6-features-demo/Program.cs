using System;
using static System.Console;

namespace csharp6_features_demo
{
    class Program
    {
        static string FirstName { get; set; } = "Swaminathan";
        static string LastName { get; set; } = "Vetri";
        static void Main(string[] args)
        {
            WriteLine("## Expression Bodied function ##");
            ExpressionBodiedFunction(); //one liner functions can be written as expression bodies

            WriteLine("## Using Statics ##");
            UsingStatic us = new UsingStatic();

            WriteLine("## Null Conditional Operators ##");
            NullConditionalOperator nco = new NullConditionalOperator();
            nco.Test();

            WriteLine("## String Interpolation ##");
            StringInterpolation si = new StringInterpolation();
            si.BasicInterpolation();
            si.ExpressionEvaluation();
            si.FormatOutput();

            WriteLine("## Name of ##");
            NameOf no = new NameOf();
            no.Test();

            WriteLine("## Index Initializer ##");
            IndexInitializer ii = new IndexInitializer();
            ii.Test();

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        static void ExpressionBodiedFunction() => Console.WriteLine($"{FirstName} , {LastName}"); //string intepolation in 6.0
    }
}
