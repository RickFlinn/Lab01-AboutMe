using System;

namespace AboutMe
{
    class Program
    {
        /* Uses the console to ask the user a series of questions about me, takes in user input through the console, and compares
         *    the user's responses to a set of answers for each question, and tracks the number of times they have guessed 
         *    questions correctly. After all questions have been asked, the user is given a message telling them what their
         *    final score is out of the total possible, as well as a brief piece of feedback.
        */
        static void Main(string[] args)
        {
            string[] questions =
            {  "What is my favorite color?",
                "What's my new favorite programming language?",
                "Do I prefer music without vocals?",
                "Do I hate cats?",
                "What state was I born in?"
            };
            string[] answers = { "blue", "c#", "yes", "no", "missouri" };

            Console.WriteLine("Here, have some generic questions about me!");

            int score = AskQuestions(questions, answers);

            Console.WriteLine(UserScoreMessage(score, questions.Length));
        }

        // Takes in arrays of questions and answers, respectively. For each question/answer pair, this method
        //   calls the QuestionUser method to determine if the user guessed correctly. A counter tracks how many questions
        //   the user has answered correctly. After all questions have been asked, returns the number of correct guesses.
        public static int AskQuestions(string[] questions, string[] answers)
        {
            int score = 0;
            try
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    if (QuestionUser(questions[i], answers[i]))
                    {
                        score++;
                    }
                }
            } catch (IndexOutOfRangeException xcept)
            {
                Console.WriteLine("Whoops! Looks like there probably aren't enough answers matched to my questions.");
                Console.WriteLine(xcept.Message);
            }
            catch (Exception xcept)
            {
                Console.WriteLine(xcept.Message);
            }
            return score;
        }

        // Takes in question and answer string as parameters, prints the question to the console, and then
        //   checks user console input against the correct answer. If the user guessed correctly, returns true; 
        //   otherwise, returns false.
        // For yes or no questions, if the user inputs "true"/"y", or "false"/"n", their answer will be converted 
        //   to a "yes" or "no", respectively.
        public static bool QuestionUser (string question, string answer)
        {
            bool isCorrect = false;
            Console.WriteLine(question);

            try
            {
                string userGuess = Console.ReadLine();
                Console.WriteLine($"You guessed: {userGuess}");
                string guess = userGuess.ToLower();

                // Converts y/n and true/false user answers to yes/no format.
                if (guess == "true" || guess == "y")
                {
                    guess = "yes";
                }
                if (guess == "false" || guess == "n")
                {
                    guess = "no";
                }


                if (guess == answer)
                { 
                    Console.WriteLine("You guessed right!");
                    isCorrect = true;
                } else
                {
                    Console.WriteLine("You guessed wrong.");
                }
            } catch
            {
                Console.WriteLine($"Exception at Question: {question}");
                throw;
            }
            return isCorrect;
        }

        // Takes in a user's guess score and the total score possible, then returns a final score message for the user
        //   based on their score.
        public static string UserScoreMessage(int score, int possible)
        {
            string scoreMsg = $"You got {score} out of {possible} correct! ";
            string feedback;
            if (score == 5)
            {
                feedback = "Nice guessing!";
            } else if (score > possible / 2) // The quotient of two integers in C# always rounds towards zero.
            {
                feedback = "Pretty good!";
            } else if (score > 0)
            {
                feedback = "You did your best, I guess.";
            } else
            {
                feedback = "Whiffed it. Completely.";
            }
            return scoreMsg + feedback;
        }
    }
}
