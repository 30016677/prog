using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e1 = new Employee[]
            {
                new Employee("bob", "123456", "bob@blah.com", "123-456-789", "1234567-89", "bob123", "password123"),
                new Employee("bob", "123456", "bob@blah.com", "123-456-789", "1234567-89", "bob123", "password123"),
                new Employee("bob", "123456", "bob@blah.com", "123-456-789", "1234567-89", "bob123", "password123"),
                new Employee("bob", "123456", "bob@blah.com", "123-456-789", "1234567-89", "bob123", "password123"),
                new Employee("bob", "123456", "bob@blah.com", "123-456-789", "1234567-89", "bob123", "password123"),
            };

            foreach(Employee x in e1)
            {
                Console.WriteLine($"\n" +
                    $"Name: {x.Fname}\n" +
                    $"Phone: {x.PhoneNum}\n" +
                    $"Email: {x.Email}\n" +
                    $"Username: {x.Uname}\n" +
                    $"Password: {x.Password}"
                    );
            }

            Console.ReadLine();    
            
        }
    }
    class Employee
    {
        private string fname;
        private string phoneNum;
        private string email;
        private string irdNum;
        private string bankNum;
        private string uname;
        private string password;

        public string Fname { get { return fname; } set { fname = value; } }
        public string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string IrdNum { private get { return irdNum; } set { irdNum = value; } }
        public string BankNum { private get { return bankNum; } set { bankNum = value; } }
        public string Uname { get { return uname; } set { uname = value; } }
        public string Password { get { return password; } set { password = value; } }




        public Employee()
        {

        }
        public Employee(string _fname, string _phoneNum, string _email, string _irdNum, string _bankNum, string _uname, string _password)
        {
            fname = _fname;
            phoneNum = _phoneNum;
            email = _email;
            irdNum = _irdNum;
            bankNum = _bankNum;
            uname = _uname;
            password = _password;
        }
    }
}
