namespace WebApplication1.Service.Student
{
    public interface IStudentService
    {
        Task<WebApplication1.Entities.Models.Student> AddStudentAsync(WebApplication1.Entities.Models.Student student);
        Task<WebApplication1.Entities.Models.Student> UpdateStudentAsync(int studentId, WebApplication1.Entities.Models.Student updatedStudent);
        Task<Task> DeleteStudentAsync(int studentId);
        Task<WebApplication1.Entities.Models.Student> ViewStudent(int studentId);
    }
}
