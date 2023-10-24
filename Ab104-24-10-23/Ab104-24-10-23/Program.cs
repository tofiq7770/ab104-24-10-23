using Ab104_24_10_23;
using System;
using System.Collections.Generic;

class Program
{
    static List<Quiz> quizzes = new List<Quiz>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine(" ==================== \n Welcome to Quiz World \n ==================== \n [1] Create new quiz \n [2] Solve a quiz \n [3] Show quizzes \n [0] Quit ");
           t:
            Console.Write("Select an option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateNewQuiz();
                    break;
                case 2:
                    SolveQuiz();
                    break;
                case 3:
                    ShowQuizzes();
                    break;
                case 0:
                    Environment.Exit(0); //internetde arashdirdim (You can use Environment.Exit(0); and Application.Exit --- Environment.Exit(0) is cleaner.)
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    goto t;
            }
        }
    }

    static void CreateNewQuiz()
    {
        Quiz quiz = new Quiz();
        Console.Write("Enter quiz name: ");
        quiz.Name = Console.ReadLine();

        Console.Write("How many questions do you want to add? \n >>> : ");
        int numQuestions = int.Parse(Console.ReadLine());

        for (int i = 0; i < numQuestions; i++)
        {
            Question question = new Question();
            Console.Write("Enter the text of question " + (i + 1) + ": ");
            question.Text = Console.ReadLine();

            question.Variants = new List<string>();
            for (int j = 1; j <= 4; j++)
            {
                Console.Write("Enter variant " + j + ": ");
                question.Variants.Add(Console.ReadLine());
            }

            Console.Write("Enter the correct variant number: ");
            question.CorrectVariant = int.Parse(Console.ReadLine());

            quiz.Questions.Add(question);
        }

        quiz.Id = quizzes.Count + 1;
        quizzes.Add(quiz);
    }

    static void SolveQuiz()
    {
        Console.Write("Enter the quiz ID you want to solve: ");
        int quizId = int.Parse(Console.ReadLine());

        Quiz quiz = quizzes.Find(x => x.Id == quizId);
        if (quiz == null)
        {
            Console.WriteLine("Quiz not found.");
            return;
        }

        int score = 0;
        int questionNumber = 1;

        foreach (var question in quiz.Questions)
        {
            Console.WriteLine("Question " + questionNumber + ": " + question.Text);
            for (int i = 0; i < question.Variants.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + question.Variants[i]);
            }

            Console.Write("Your answer: ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
            if (userAnswer == question.CorrectVariant)
            {
                score++;
            }

            questionNumber++;
        }

        Console.WriteLine("Quiz completed. Your score: " + score + " / " + quiz.Questions.Count);
    }

    static void ShowQuizzes()
    {
        Quiz quiz = new Quiz();
        Console.WriteLine("Quizzes:");
        foreach (Quiz quizes in quizzes) 
        {
            Console.WriteLine("ID: " + quizes.Id + " | Name: " + quizes.Name);
        }
        if (quiz != null)
        {
            Console.WriteLine("No quiz is found");
        }
        
        
    }
}
