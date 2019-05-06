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
        public int Height { get; set; }
        public string EyeColor { get; set; }

        public People(string firstname, string lastname, int age, int height, string eyecolor)
        {
            firstname = FirstName;
            lastname = LastName;
            age = Age;
            height = Height;
            eyecolor = EyeColor;
        }

        public override string ToString()
        {
            return string.Format("{0}{1} is {2} years old. They are {3} inches tall, and have {4} eyes.", FirstName, LastName, Age, Height, EyeColor);

        }
    }
}
