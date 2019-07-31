using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umls
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person.counter = 0;

            string check = "y";
            while(check == "y")
            {
                Console.Clear();
                Person.counter++;
                Person newPerson = new Person();
                Console.Write("enter first name: ");
                newPerson.Fname = Console.ReadLine();
                Console.Write("enter last name: ");
                newPerson.Lname = Console.ReadLine();
                Console.Write("enter age: ");
                newPerson.Age = int.Parse(Console.ReadLine());
                people.Add(newPerson);
                Console.Write("add another person? (Y/N) ");
                check = Console.ReadLine();

            }

            Console.WriteLine($"People created: {Person.counter}");

            foreach(Person x in people)
            {
                Console.WriteLine($"\nName: {x.Fname} {x.Lname}\nage: {x.Age}");

            }

            List<Person> peeps = new List<Person>()
            {
                new Person("bob", "smith", 30),
                new Person("jane", "doe", 30),
                new Person("jimmie", "jack", 30)
            };

                  

            //task2
            ShoppingCart c1 = new ShoppingCart();
            c1.Uname = "Jane";
            c1.Pword = "pasword123";
            //c1.Cart = 





            Console.ReadLine();
        }
    }
    class Person
    {
        private string fname;
        private string lname;
        private int age;
        public int counter;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        
        public Person()
        {

        }
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }

        public string ReturnDeets()
        {
            return $"name: {Fname} {Lname}.\nAge: {Age}";
        }
    }
   
}
