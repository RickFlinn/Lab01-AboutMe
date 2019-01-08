using System;

namespace AboutMe
{
    class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        { 
            Console.WriteLine("Pass the following trials and you will earn my favor!");
            try
            {
                QuestionOne();
                QuestionTwo();
                QuestionThree();
                QuestionFour();
                QuestionFive();
                Console.WriteLine($"You got {counter} out of 5 correct!");

            } catch (Exception xcept)
            {
                Console.WriteLine(xcept.Message);
            }

        }

        public static void QuestionOne()
        {
            string question = "What is my favorite color?";
            string answer = "green";
            Console.WriteLine(question);

            try
            {
                string userGuess = Console.ReadLine();
                string formattedGuess = userGuess.ToLower();

                if (answer == formattedGuess)
                {
                    counter++;
                    Console.WriteLine("Yup!");
                } else
                {
                    Console.WriteLine("Nope.");
                }
            } catch
            {
                Console.WriteLine("Exception at Question One!");
                throw;
            }
        }

        public static void QuestionTwo()
        {
            
        }

        public static void QuestionThree()
        {

        }

        public static void QuestionFour()
        {

        }

        public static void QuestionFive()
        {

        }
    }
}
