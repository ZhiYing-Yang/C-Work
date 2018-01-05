using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4._1
{
    class Person
    {
        public string name;
        private int age;
        private string phoneNumber;
        public int Age
        {
            get { return age; }
            set { if (value>=15&&value<=130) age = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { if (value.Length == 11) phoneNumber = value; }
        }
        public Person(){}
        public string Print()
        {
            return string.Format("{0,-20}{1,-10}{2,-20}", name, age, phoneNumber);
        }
    }
}
