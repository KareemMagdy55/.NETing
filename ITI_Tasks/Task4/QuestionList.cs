using System.Text;

namespace Lab1.Task4;


public class Question
{
    public string Text { get; set; }
    public string Answer { get; set; }
    
    public Question(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }

    public override string ToString()
    {
        return $"Question: {Text}, Answer: {Answer}\n";
    }
}
public class QuestionList : List<Question> {
    public FileStream File_Stream { get; set; }

    public QuestionList( string path)  {
        File_Stream = File.Create(path);
        Console.WriteLine(File.Exists(path));
    }

    public void AddQuestion(Question question) {
        byte[] info = new UTF8Encoding(true).GetBytes(question.ToString());  
        
        File_Stream.Write(info, 0, info.Length);  
    }
 
}