using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTicketProject
{
    internal class Customer
    {
        public string Name;
        public bool Gender;
        public int Age;
        public bool Elderly;
        public bool Disabled;

        public Customer(string name, bool gender, int age, bool elderly, bool disabled)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Elderly = elderly;
            Disabled = disabled;
        }
    }
}
