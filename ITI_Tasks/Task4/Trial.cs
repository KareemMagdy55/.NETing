namespace Lab1.Task4;

public class Trial {
    public static void Main() {
        QuestionList questions = new QuestionList( @"trial.txt");
        
        Question q1 = new Question("Q1", "A1");
        Question q2 = new Question("Q2", "A2");
        Question q3 = new Question("Q3", "A3");

        questions.Add(q1);
        questions.Add(q2);
        questions.Add(q3);


        FinalExam finalExam = new FinalExam(ExamStatus.Finished, questions);
        PracticeExam practiceExam = new PracticeExam(ExamStatus.Finished, questions);
        
        practiceExam.ShowAnswers();
        Console.WriteLine("----------------------------------------");
        finalExam.ShowAnswers();
    }
}