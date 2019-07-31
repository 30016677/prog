using System;

namespace encP2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int[] grades = new int[4];


            s1.Grades = InputGrades(grades);
            Console.WriteLine($"Average grade is: {s1.ShowAverageGrade()}");


            s1.Fname = ValidateString(" ", "student's full name");
            Console.Write("Please enter student's email: ");
            s1.Email = Console.ReadLine();
            Console.Write("Please enter student's address: ");
            s1.Address = Console.ReadLine();
            s1.ID = ValidateInt(0, "Student's ID", false);
            Console.Write("Please enter student's password: ");
            s1.Password = Console.ReadLine();
            s1.Grades = InputGrades(grades);
            


            Console.WriteLine(s1.Fname);
            Console.WriteLine(s1.ID);
            Console.WriteLine(s1.ShowAverageGrade());

            Console.ReadLine();
        }

        static string ValidateString(string input, string query)
        {
            bool test = true;

            Console.Write($"Please enter {query}: ");
            input = Console.ReadLine();
            do
            {
                foreach (char c in input)
                {
                    if (Char.IsDigit(c))
                    {
                        test = false;
                        Console.Write($"\nError. Please enter {query}: ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        test = true;
                    }
                    break;
                }
            } while (!test);
            return input;
        }
        static int ValidateInt(int input, string query, bool gradeTest)
        {            
            bool test = false;
            
            Console.Write($"Please enter {query}: ");
            test = int.TryParse(Console.ReadLine(), out input);
            do
            {
                if (!test)
                {
                    Console.Write($"\nError. Please enter {query}: ");
                    test = int.TryParse(Console.ReadLine(), out input);
                }
            } while (!test);
                        
            return input;                
        }
        static int[] InputGrades(int[] grades)
        {
            string query;
            for (int i = 0; i < 4; i++)
            {
                query = $"Enter grade {i + 1}";
                grades[i] = ValidateInt(0, query, true);
            }
            return grades;
        }
    }
    class Student
    {
        public string Fname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ID { get; set; }
        public string Password { get; set; }
        public EmergencyContact Contact { get; set; }

        int[] grades = new int[4];
        public int[] Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public Student()
        {

        }

        public float ShowAverageGrade()
        {
            int sum = 0;
            foreach (int x in Grades)
            {                
                sum += x;
            }
            return sum / 4;
        }


    }
    class EmergencyContact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
