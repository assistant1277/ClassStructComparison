using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassStruct.model
{
    public class People
    {
        public string name;
        public int age;
        public People() : this("Unknown", 0)
        {
        }
        public People(string names) : this(names, 0)
        {
        }

        public People(string names, int ages)
        {
            name = names;
            age = ages;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("name " + name + ", age " + age);
        }
    }

    class Employee : People
    {
        public string jobTitle;
        public Employee(string name, int age, string role) : base(name, age)
        {
            jobTitle = role;
        }
        public void DisplayEmployeeDetails()
        {
            DisplayDetails();
            Console.WriteLine("job title " + jobTitle);
        }
    }
}
