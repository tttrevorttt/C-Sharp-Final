using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public People(string firstname = "", string lastname = "", int age = 0)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", FirstName, LastName, Age);

        }
    }
}
