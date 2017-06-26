using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp6_features_demo
{
    class NullConditionalOperator
    {
        Vehicle myVehicle;
        public void Test()
        {
            WriteLine("Before initializing vehicle...");
            //WriteLine($"I own {myVehicle.Make} vehicle"); //will fail at runtime without NULL conditional operator

            WriteLine($"I own {myVehicle?.Make} vehicle"); // won't fail but prints nothing for myVehicle.Make
            myVehicle?.Move(); //won't fail 

            myVehicle = new Vehicle();
            WriteLine("After initializing vehicle...");
            WriteLine($"I own {myVehicle?.Make} vehicle");
            myVehicle?.Move();
        }
    }

    class Vehicle
    {
        public string Make { get; set; } = "BMW";
       
        public void Move()
        {
            WriteLine("Vehicle is Moving...");
        }
    }
}
