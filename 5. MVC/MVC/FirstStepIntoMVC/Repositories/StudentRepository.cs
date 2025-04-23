using FirstStepIntoMVC.Models;

namespace FirstStepIntoMVC.Repositories;

public class StudentRepository : IStudentRepository {
    private List<Student> students;


    public StudentRepository() =>
        students = new List<Student> {
            new Student { Grade = "A+", Id = 1, Name = "Shokry" },
            new Student { Grade = "B+", Id = 2, Name = "Fathy" },
            new Student { Grade = "C+", Id = 3, Name = "Semada" },
            new Student { Grade = "D+", Id = 4, Name = "Adnan" }
        };
    

    public List<Student> GetAll() =>
        students;


    public Student GetById(int id)
        => students.FirstOrDefault(s => s.Id == id);

    public void AddStudent(Student student) => students.Add(student);
}