// See https://aka.ms/new-console-template for more information
    using System;

    namespace FirstRepo
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("What is your grade percent? ");
                int grade = int.Parse(Console.ReadLine());

                String letter = "Error";

                if (grade >= 90)
                    {
                    letter = "A";
                    }
                else if (grade >= 800)
                    {
                    letter = "B";
                    }
                else if (grade >= 70)
                    {
                    letter = "C";
                    }
                else if (grade >= 60)
                    {
                    letter = "D";
                    }
                else
                    {
                    letter = "F";
                    }

                Console.WriteLine($"Your letter grade is: {letter}");

                if (grade >= 70)
                {
                    Console.WriteLine("Congratulations! You passed the class!");
                }
                else
                {
                    Console.WriteLine("Stay focused and you'll get it next time!");
                }
                    
            }
        }
    }

