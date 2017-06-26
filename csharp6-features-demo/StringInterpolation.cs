using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp6_features_demo
{
    class StringInterpolation
    {
        public void BasicInterpolation()
        {
            string firstName = "Swaminathan";
            string lastName = "Vetri";

            string fullName = $"{firstName} {lastName}";
            Console.WriteLine($"Fullname : {fullName}");
        }

        public void ExpressionEvaluation()
        {
            List<Person> persons = new List<Person>
            {
                new Person { FirstName = "John", LastName ="Doe"},
                new Person { FirstName = "John", LastName ="Foo"},
                new Person { FirstName="Chris", LastName="Tucker"}
            };
            Console.WriteLine($"No. of Persons with First Name John : {persons.Where(person => string.Compare(person.FirstName, "John", true) == 0).Count()}");
        }

        public void FormatOutput()
        {
            List<Person> persons = new List<Person>
            {
                new Person { FirstName = "John", LastName ="Doe", Age = 35},
                new Person { FirstName = "John", LastName ="Foo" , Age = 30},
                new Person { FirstName="Chris", LastName="Tucker", Age = 25},
                new Person { FirstName="John", LastName ="Duck", Age = 33}
            };
            Console.WriteLine($"Average age : {persons.Average(person => person.Age):F3}");
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
