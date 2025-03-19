namespace WebApplication1.Service.Course
{
    public interface ICourseService
    {
        Task<WebApplication1.Entities.Models.Course> AddCourseAsync(WebApplication1.Entities.Models.Course course);
        Task<WebApplication1.Entities.Models.Course> UpdateCourseAsync(int courseId, WebApplication1.Entities.Models.Course updatedCourse);
        Task<Task> DeleteCourseAsync(int courseId);
        Task<WebApplication1.Entities.Models.Course> ViewCourse(int courseId);
    }
}
