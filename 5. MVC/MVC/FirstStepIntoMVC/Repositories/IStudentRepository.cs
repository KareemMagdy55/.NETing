using FirstStepIntoMVC.Models;

namespace FirstStepIntoMVC.Repositories;

public interface IStudentRepository {
    public List<Student> GetAll();
    public Student GetById(int id);
    public void AddStudent(Student student);
}