using System;
using System.Collections;
using System.Linq;




namespace Final
{
    class Program
    {
        static void Main()
        {
            QueryArrayList();
            Console.ReadLine();
            
        }

        static void QueryArrayList()
        {
            ArrayList people = new ArrayList()
            {
                new People
                {
                    FirstName = "Trevor",
                    LastName = "Gorham",
                    Age = 20
                },
                new People
                {
                    FirstName = "John",
                    LastName = "Apple",
                    Age = 15

                },
                new People
                {
                    FirstName = "Jessie",
                    LastName = "Steers",
                    Age = 32

                },
                new People
                {
                    FirstName = "Ceeder",
                    LastName = "Write",
                    Age = 37
                },
                new People
                {
                    FirstName = "Alison",
                    LastName = "Frenton",
                    Age = 21
                 
                }
            };
            Console.WriteLine("Names that Start with J");
            var peoples = people.OfType<People>();
            var peoplewithJ = from j in peoples
                              where j.FirstName.StartsWith("J")
                              select j;
            foreach (var jname in peoplewithJ)
            {
                Console.WriteLine(jname.ToString());
            }
            Console.WriteLine("\nOrder by age decending order");
            var decendpeople = from name in peoples
                               orderby name.Age descending
                               select name;

            int avg = 0;
            foreach (var dname in decendpeople)
            {
                Console.WriteLine(dname.ToString());
                avg = Convert.ToInt32(dname.Age) + avg; 
            }
            avg = avg / people.Count;
            Console.WriteLine("\nThe average of all ages is "+avg );
            


        }
    }
}
