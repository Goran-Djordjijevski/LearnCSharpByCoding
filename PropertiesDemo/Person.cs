using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string MyProperty { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        private int _age;

        public int Age
        {
            get { var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                 
                return years;
            }
            set { _age = value; }
        }
    }
}
