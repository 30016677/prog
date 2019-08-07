using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("John", "Smith", 123456789);

            Teacher t = new Teacher("Bob", "Dylan", "321654987", "M-06");


            Console.WriteLine(s.GetStdDeets());

            Console.WriteLine(t.GetTeachDeets());


            Console.ReadLine();
        }
    }
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

    }
    class Student:Person
    {
        public int StudentId { get; set; }

        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _stdid;
        }
        public string GetStdDeets()
        {            
            return $"First name: {Fname}\nLast name: {Lname}\nID: {StudentId.ToString()}";
        }
    }
    class Employee:Person
    {
        public string EmployeeId { get; set; }

    }
    class Teacher:Employee
    {
        public string Office { get; set; }

        public Teacher (string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _empid;
            Office = _office;
        }

        public string GetTeachDeets()
        {
            return $"\nFirst name: {Fname}\nLast name: {Lname}\nID: {EmployeeId}\nOffice: {Office}";
        }
    }
}
