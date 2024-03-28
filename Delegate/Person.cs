using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
 public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int Salary { get; set; }



        public Person(string name, string surname, string adress, int salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
            this.Salary = salary;
        }
    }
}
