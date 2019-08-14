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
            
            Console.WriteLine("Enter animal type. Pig(1) Sheep(2)");
            string type = Console.ReadLine();
            if (type == "1")
            {
                Pig p01 = new Pig();
                Console.Write("Enter new pig's id: ");
                p01.Id = Console.ReadLine();
                Console.Write("Enter new pig's name: ");
                p01.Name = Console.ReadLine();
                Console.Write("Domestic(1) or Kuni Kuni(2): ");
                p01.MyBreed = Pig.Breeds[int.Parse(Console.ReadLine()) - 1];
                Console.WriteLine(p01.GetAnimalDetails());

                foreach (CheckUp x in p01.VetCheck)
                {
                    Console.WriteLine($"Date: {x.Date}");
                }
            }
            


            





           

            Console.ReadLine();
        }
    }
    class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
        public int TotalCounter { get; set; }
        public List<CheckUp> VetCheck = new List<CheckUp>();

        public Animal()
        {
            TotalCounter++;
        }
        
        
    }
    class Pig : Animal
    {
        public static List<string> Breeds = new List<string>() {"Domestic", "Kuni Kuni" };
        public string MyBreed { get; set; }
        public int Counter { get; set; }
        //public List<CheckUp> VetCheck = new List<CheckUp>();

        public Pig()
        {
            Counter++;
        }
        public Pig(string _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
        public string GetAnimalDetails()
        {
            return $"\nName: {Name} \nID: {Id} \nBreed: {MyBreed} \n\nTotal Pigs: {Counter.ToString()} " +
                $"\nTotal Animals: {TotalCounter.ToString()}";
        }

    }   
    class Sheep : Animal
    {
        public List<string> Breed { get; set; }

    }
    class Llamas : Animal
    {
        public List<string> Breed { get; set; }

    }
    class Cows : Animal
    {
        public List<string> Breed { get; set; }

    }
    class Birds : Animal
    {
        public List<string> Breed { get; set; }

    }
    class CheckUp
    {
        public string Date { get; set; }
        public string Vet { get; set; }
        public string Notes { get; set; }

        public CheckUp(string date, string vet, string notes)
        {
            
        }
    }
}
