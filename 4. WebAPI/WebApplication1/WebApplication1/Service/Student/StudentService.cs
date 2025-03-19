using WebApplication1.Entities.Repositories;

namespace WebApplication1.Service.Student;

public class StudentService : IStudentService{
    private readonly IUnitOfWork unitOfWork;

    public StudentService(IUnitOfWork unitOfWork) {
        this.unitOfWork = unitOfWork;
    }

    public async Task<WebApplication1.Entities.Models.Student> AddStudentAsync(WebApplication1.Entities.Models.Student student) {
        await unitOfWork.StudentRepository.AddAsync(student);
        await unitOfWork.CompleteAsync();
        return student;
    }

    public async Task<WebApplication1.Entities.Models.Student> UpdateStudentAsync(int studentId, WebApplication1.Entities.Models.Student updatedStudent) {
        var student = await unitOfWork.StudentRepository.GetFirstOrDefaultAsync(s => s.ID == studentId);
        if (student == null) throw new KeyNotFoundException("Student not found.");
        
        student.Name = updatedStudent.Name;
        student.EmailAddress = updatedStudent.EmailAddress;
        
        await unitOfWork.StudentRepository.UpdateAsync(student);
        await unitOfWork.CompleteAsync();
        return updatedStudent;
    }
    

    public async Task<Task> DeleteStudentAsync(int studentId) {
        var student = await unitOfWork.StudentRepository.GetFirstOrDefaultAsync(s => s.ID == studentId);
        if (student == null) throw new KeyNotFoundException("Student not found.");

        await unitOfWork.StudentRepository.RemoveAsync(student);
        await unitOfWork.CompleteAsync();
        return Task.CompletedTask;
    }

    public async Task<WebApplication1.Entities.Models.Student> ViewStudent(int studentId) {
        var student = await unitOfWork.StudentRepository.GetFirstOrDefaultAsync(s => s.ID == studentId);
        if (student == null) throw new KeyNotFoundException("Student not found.");
        return student;
    }
}