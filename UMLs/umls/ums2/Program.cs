using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            bool check2 = true;
            do
            {
                ShoppingCart s1 = new ShoppingCart();
                Console.Write("enter username: ");
                s1.Uname = Console.ReadLine();
                Console.Write("enter password: ");
                s1.Pword = Console.ReadLine();

                do
                {
                    Console.WriteLine("what would you like to add: ");
                    s1.Cart.Add(Console.ReadLine());
                    Console.WriteLine("Enter price: $");
                    s1.CartTotal += double.Parse(Console.ReadLine());
                    
                } while (check2);

                Console.Write("would you like to try again (Y/N)");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                {
                    check2 = false;
                }

            } while (check);
        }
    }
    class ShoppingCart
    {
        private string username;
        private string password;
        private List<string> cart = new List<string>();
        private double cartTotal = 0;

        public string Uname { get { return username; } set { username = value; } }
        public string Pword { get { return password; } set { password = value; } }
        public List<string> Cart { get { return cart; } set { cart = value; } }
        public double CartTotal { get { return cartTotal; } set { cartTotal = value; } }


    }
}
