using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_calc
{
    class Program
    {
        public static float Sum(float num1, float num2)
        {
            float total;
            total = num1 + num2;
            return total;
        }

        public static int Selection()
        {
            Console.Write("Press 1 for simple calculator and 2 for advanced functions: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                return SimpleCalc();
            }
            if (choice == 2)
            {
                return advancedCalc();
            }
            else 
            {
                return choice;
            }
           
        }
        public static int SimpleCalc()
        {
            Console.Write("Enter a number: ");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter another number: ");
            float num2 = Convert.ToInt32(Console.ReadLine());




            switch (op)
            {
                case "+":
                    Console.WriteLine("The anwser is: " + Sum(num1, num2));
                    Console.Read();
                    break;

                case "-":
                    Console.WriteLine("The anwser is: " + (num1 - num2));
                    Console.Read();
                    break;

                case "*":
                    Console.WriteLine("The anwser is: " + (num1 * num2));
                    Console.Read();
                    break;

                case "/":
                    Console.WriteLine("The anwser is: " + (num1 / num2));
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Calulations only :-(");
                    break;

            }
            
            return 0;
        }
        public static int advancedCalc()
        {
            Console.WriteLine("Enter 1 for Rectangle, 2 for circle and 3 for sphere ");
            int advancedChoice = Convert.ToInt32(Console.ReadLine());

            if (advancedChoice == 1) //rectangle
            {
                Console.WriteLine("Enter first side ");
                float rect1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second side ");
                float rect2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The area of the rectangle is: " + (rect1 * rect2));
                Console.WriteLine("The circumference of the rectangle is: " + ((rect1 * 2) + (rect2 * 2)));
                Console.Read();
            }

            if (advancedChoice == 2) //circle
            {
                Console.WriteLine("Enter radius: ");
                float radius = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("The area of the circle is: " + (0.75 * (3.142 * (radius * radius))));
                Console.WriteLine("The circumference of the circle is: " + ((3.142 * 2) * radius));
                Console.Read();
            }

            if (advancedChoice == 3) //sphere
            {
                Console.WriteLine("Enter radius: ");
                float radius = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("The volume of the sphere is: " + (0.75 * (3.142 * (radius * radius * radius))));
                Console.WriteLine("The circumference of the sphere is: " + (3.142 * 4 * (radius * radius)));
                Console.Read();
            }
            return 0;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter how many calculations you would like ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < count; i++)
            //{

            string restart = "";
            do

            {
                Selection();
                Console.WriteLine("press any key to continue and q to quit");
                restart = Console.ReadLine();
                    }
            while (restart != "q");
            
            //}

            



        }
        }
    }


