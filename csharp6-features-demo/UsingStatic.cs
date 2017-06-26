using static System.Console; //removes the need to use Console.* for accessing static methods
using static System.String; //removes the need to use System.* for accessing static methods

namespace csharp6_features_demo
{
    class UsingStatic
    {
        public string Name { get; set; }
        
        public UsingStatic()
        {
            WriteLine("I'm in constructor");
            if(IsNullOrEmpty(Name))
            {
                WriteLine("String is empty");
            }
            else
            {
                WriteLine("String is not empty");
            }
        }

        static void PrintName()
        {
            WriteLine("I'm from a static method");
        }
    }
}
