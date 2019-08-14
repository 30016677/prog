using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal01 = new Animal();

            bool b = true;

            
            do
            {
                Console.WriteLine("Would you like to view animals or add a new animal? (view/add)");
                string input = Console.ReadLine();
                if (input == "view")
                {
                    Console.WriteLine(animal01.GetAnimal());
                }
                else if (input == "add")
                {
                    
                    Console.WriteLine("Type?");
                    animal01.Type = Console.ReadLine();
                    Console.WriteLine("Name?");
                    animal01.Name = Console.ReadLine();
                    Console.WriteLine("ID?");
                    animal01.Id = Console.ReadLine();
                }
            } while (b);

            
            


            Console.ReadLine();
        }
    }
    class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal()
        {
        }

        public string GetAnimal()
        {
            return Id + Name + Type;
        }
    }
    class Pig : Animal
    {
        public List<string> Count { get; set; }


    }   
    class Sheep : Animal
    {

    }
    class Llamas : Animal
    {

    }
    class Cows : Animal
    {

    }
    class Birds : Animal
    {

    }
}
