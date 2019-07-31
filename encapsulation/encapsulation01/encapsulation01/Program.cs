using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cc c1 = new Cc();
            c1.Name = "John Smith";
            c1.Number = "0123456789";
            c1.Security = "123";
            c1.ExpireDate = "1/20";

            Console.WriteLine($"Name: {c1.Name}\n" +
                $"Expiration: {c1.ExpireDate}\n");

            c1.DisplayForbidden(c1, "password123");

            Console.ReadLine();
        }
    }
    class Cc
    {
        private string name;
        private string number;
        private string security;
        private string expireDate;

        public string Name {  get { return name; } set { name = value; } }
        public string Number { private get { return number; } set { number = value; } }
        public string Security { private get { return security; } set { security = value; } }
        public string ExpireDate { get { return expireDate; } set { expireDate = value; } }

        public Cc()
        {

        }

        public void DisplayForbidden(Cc c1, string pw)
        {
            if(pw == "password123")
            {
                Console.WriteLine(c1.Number);
                Console.WriteLine(int.Parse(c1.Security));
            }
        }

    }
}
