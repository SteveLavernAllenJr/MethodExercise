using System;

namespace MethodExercise
{
     internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("what is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("what is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("what is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"My name is {userName} and my favorite animal happens to be a {userAnimal}.");
            Console.WriteLine($"Since today is get to know about {userName} day, i will also let you know that my favorite color is {userColor}!");
            Console.WriteLine($"I even listen to quite a variety of music, from rap to country to techno, and rock; however, my favorite band ever is {userBand}!");

            //int answer1 = add(500, 500);
            //int answer2 = subtract(1000, 500);
            //int answer3 = multiply(10, 500);
            //int answer4 = divide(200, 2);
            //int answer5 = modulus(27, 7);


            Console.WriteLine(Sum(500, 500, 400, 400, 800));
            Console.WriteLine(Subtract(1000, 500));
            Console.WriteLine(Multiply (10, 500));
            Console.WriteLine(Divide (200 ,2));
            Console.WriteLine(Modulus (27, 7));
        


        }


        public static int Sum(params int [] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;

        }




    }
}


