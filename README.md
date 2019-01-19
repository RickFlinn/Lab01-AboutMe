# Lab01-AboutMe


This is a simple I/O program that asks the user to guess a series of five  questions about me, the author.

Running the program will open a new console window, which it will use to begin asking the user questions. Each time it outputs a question, it will wait to read user input, tell the user if they guessed correctly, and move on to the next question.

Some questions require that the user input a specific string - for example, my home state of `missouri`. 

Once all questions have been asked, the user will be presented with their score and a simple feedback message telling them how well they did.


## Methods 

### `AskQuestions(string[] questions, string[] answers)`
`AskQuestions` takes in two arrays of questions and answers. If there are an uneven number of questions and answers, an `IndexOutOfRangeException` will be thrown. Else, it will prompt the user to answer each question through the `Console`by calling `QuestionUser`, determine the number of questions the user has answered correctly, and return the number of correct guesses as an `int`eger.

### `QuestionUser(string question, string answer)`
Takes in a single question and answer pair, and prompts the user to guess the answer. Returns true if the user guessed correctly.
For yes/no questions, `yes`, `y`, and `true` are valid inputs for "yes", while `no`, `n`, and `false` are all acceptable inputs to respond "no".  

### `UserScoreMessage(int score, int possible)`
Takes in the user's score and the total number of questions, and returns a string that is used to tell the user their score, as well as a message that depends on how well they did. 


### Sample output to Console
```
Here, have some generic questions about me!
What is my favorite color?
green // user input
You guessed: green
You guessed wrong.
What's my new favorite programming language?
c# // user input
You guessed: c#
You guessed right!
Do I prefer music without vocals?
yes // user input
You guessed: yes
You guessed right!
Do I hate cats?
yes
You guessed: yes
You guessed wrong.
What state was I born in?
missouri
You guessed: missouri
You guessed right!
You got 3 out of 5 correct! Pretty good!
Press any key to continue . . .
```


