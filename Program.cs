using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    internal class Program
    {
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }

        class ProjectManager: Employee
        {
            public string ProjectName;
        }

        class Developer: Employee
        {
            private string ProgrammingLanguage;
        }

        static void Main(string[] args)
        {
        }
    }
}
