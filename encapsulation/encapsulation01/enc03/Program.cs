using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enc03
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0;
            int l = 0;
            int h = 0;

            w = ValidateInput(w, "width");
            l = ValidateInput(l, "lentgh");
            h = ValidateInput(h, "height");

            //Console.Write("Please enter width: ");
            //int w = int.Parse(Console.ReadLine());
            //Console.Write("Please enter length: ");
            //int l = int.Parse(Console.ReadLine()); 
            //Console.Write("Please enter height: ");
            //int h = int.Parse(Console.ReadLine());

            Box bx = new Box(w,l,h);

            Console.WriteLine($"\nThe Surface area of the box is: {bx.SurfaceArea()}");

            Console.WriteLine($"\nThe volume of the box is: {bx.Volume()}");

            Console.ReadLine();
        }
        static int ValidateInput(int number, string info)
        {
            bool check = true;
            bool confirm = false;

            do
            {
                Console.Write($"Please enter the {info} of the box: ");
                confirm = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!confirm)
                    {                        
                        Console.Write("Error, that was not a valid number.\n" +
                            $"Please enter the {info} of he box: ");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }
                } while (!confirm);

                Console.WriteLine($"{info} Set\n\n");
                break;

            } while (check);

            return number;
        }
    }
    class Box
    {
        private int Width {  get; set; }
        private int Length {  get; set; }
        private int Height {  get; set; }

        public Box(int w, int l, int h)
        {
            Width = w;
            Length = l;
            Height = h;
            Console.WriteLine("\n...box created...");
        }
        public int SurfaceArea()
        {
            return 2 * (Width * Height) + 2 * (Height * Length) + 2 * (Width * Length);
        }
        public int Volume()
        {
            return Length * Width * Height;
        }
    }

}
