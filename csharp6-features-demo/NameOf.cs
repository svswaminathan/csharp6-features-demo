using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6_features_demo
{
    class NameOf
    {
        public string Person { get; set; }
        public void Test()
        {
            Console.WriteLine(nameof(Person));
        }
    }
}
