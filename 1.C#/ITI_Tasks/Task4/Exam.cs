namespace Lab1.Task4;

public enum ExamStatus {
    Starting,
    Queued,
    Finished
}

public abstract class Exam {
    public ExamStatus examStatus { get; set; }
    public QuestionList questionList { get; set; }

    public Exam() {
        
    }

    public abstract void ShowAnswers();
    public Exam(ExamStatus examStatus, QuestionList questionList) {
        this.examStatus = examStatus;
        this.questionList = questionList;
    }
}

public class PracticeExam : Exam {
    public PracticeExam(ExamStatus examStatus, QuestionList questionList) : base(examStatus, questionList) {}

    public override void ShowAnswers() {
        if (examStatus != ExamStatus.Finished) 
            Console.WriteLine("Practice exam not finished yet");
        
        foreach (var question in questionList) 
            Console.WriteLine($"Answer : {question.Answer}");
        
    }
}
public class FinalExam : Exam {
    public FinalExam(ExamStatus examStatus, QuestionList questionList) : base(examStatus, questionList) {}

    public override void ShowAnswers() {
        if (examStatus != ExamStatus.Finished) 
            Console.WriteLine("Final exam not finished yet");

        foreach (var question in questionList) 
            Console.WriteLine(question);

    }
}