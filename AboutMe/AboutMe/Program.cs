using System;

namespace AboutMe
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Here, have some generic questions about me!");
            int score = AskQuestions();
            string finalMessage = UserScoreMessage(score);
            Console.WriteLine(finalMessage);
        }

        public static int AskQuestions()
        {
            int counter = 0;
            string 
            try
            {
                

                for (int i = 0; i < questions.Length; i++)
                {
                    if (goodAnswers[i])
                    {
                        counter++;
                    }
                }
            }
            catch (Exception xcept)
            {
                Console.WriteLine(xcept.Message);
            }
            return counter;
        }

        // Takes in question and answer string as parameters, prints the question to the console, and then
        // checks user console input against the answer string. If the user guessed correctly, returns true; otherwise, returns false.
        public static bool QuestionUser (string question, string answer)
        {
            bool isCorrect;

            try
            {
                string userGuess = Console.ReadLine();
                string guess = userGuess.ToLower();
                if (guess == answer)
                {
                    Yup();
                    isCorrect = true;
                } else
                {
                    Nope();
                }
            } catch
            {
                Console.WriteLine($"Exception at Question: {question}");
            }

        }


        /************* This is repetitive. I'm refactoring. *******************/


        //public static bool QuestionOne()
        //{
        //    string question = "What is my favorite color?";
        //    string answer = "green";
        //    bool isCorrect = false;
        //    Console.WriteLine(question);

        //    try
        //    {
        //        string userGuess = Console.ReadLine();
        //        string guess = userGuess.ToLower();

        //        if (answer == guess)
        //        {
        //            Yup();
        //            isCorrect = true;
        //        } else
        //        {
        //            Nope();
        //        }
        //    } catch
        //    {
        //        Console.WriteLine("Exception at Question One!");
        //        throw;
        //    }
        //    return isCorrect;
        //}

        //public static bool QuestionTwo()
        //{
        //    string question = "How old am I?";
        //    int answer = 24;
        //    bool isCorrect = false;

        //    Console.WriteLine(question);
        //    try
        //    {
        //        string userGuess = Console.ReadLine();
        //        int guess = int.Parse(userGuess);
        //        if (answer == guess)
        //        {
        //            Yup();
        //            isCorrect = true;
        //        } else if (answer > guess)
        //        {
        //            Console.WriteLine("Some folks say I look younger than I am.");
        //        } else
        //        {
        //            Console.WriteLine("Alright, I'm not THAT old.");
        //        }
        //    } catch (FormatException)
        //    {
        //        Console.WriteLine($"Sorry, I couldn't turn your answer into an integer value. Let's try again.");
        //        isCorrect = QuestionTwo();
        //    } catch
        //    {
        //        Console.WriteLine("Woah, something went wrong in Question Two.");
        //        throw;
        //    }

        //    return isCorrect;
        //}

        //public static bool QuestionThree()
        //{
        //    string question = "True or false: I only like country music.";
        //    string answer = "false";
        //    string wrongAnswer = "true";
        //    bool isCorrect = false;

        //    try
        //    {
        //        string userGuess = Console.ReadLine();
        //        string guess = userGuess.ToLower();
        //        if (answer == guess)
        //        {
        //            Yup();
        //            isCorrect = true;
        //        } else if (wrongAnswer == guess)
        //        {
        //            Nope();
        //        }
        //    } catch
        //    {
        //        Console.WriteLine("Something went wrong in Question Three!");
        //        throw;
        //    }

        //    return isCorrect;
        //}

        //public static bool QuestionFour()
        //{

        //}

        //public static bool QuestionFive()
        //{

        //}

        public static void Yup()
        {
            Console.WriteLine("Yup!");
        }

        public static void Nope()
        {
            Console.WriteLine("Nope.");
        }

        public static string UserScoreMessage(int score)
        {
            string scoreMsg = $"You got {score} out of 5 correct! ";
            string feedback;
            if (score == 5)
            {
                feedback = "Nice guessing!";
            } else if (score > 3)
            {
                feedback = "Pretty good!";
            } else if (score > 1)
            {
                feedback = "You did your best, I guess.";
            } else
            {
                feedback = "Maybe not the best performance.";
            }
            return scoreMsg + feedback;
        }
    }
}
