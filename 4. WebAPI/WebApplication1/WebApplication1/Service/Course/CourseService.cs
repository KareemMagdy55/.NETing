using WebApplication1.Entities.Repositories;


namespace WebApplication1.Service.Course;

public class CourseService : ICourseService {
    private readonly IUnitOfWork unitOfWork;

    public CourseService(IUnitOfWork unitOfWork) {
        this.unitOfWork = unitOfWork;
    }

    public async Task<WebApplication1.Entities.Models.Course> AddCourseAsync(WebApplication1.Entities.Models.Course course) {
        await unitOfWork.CourseRepository.AddAsync(course);
        await unitOfWork.CompleteAsync();
        return course;
    }

    public async Task<WebApplication1.Entities.Models.Course> UpdateCourseAsync(int courseId, WebApplication1.Entities.Models.Course updatedCourse) {
        var course = await unitOfWork.CourseRepository.GetFirstOrDefaultAsync(c => c.ID == courseId);
        if (course == null) throw new KeyNotFoundException("Course not found.");

        course.Name = updatedCourse.Name;
        course.Description = updatedCourse.Description;

        await unitOfWork.CourseRepository.UpdateAsync(course);
        await unitOfWork.CompleteAsync();
        return course;
    }


    public async Task<Task> DeleteCourseAsync(int courseId) {
        var course = await unitOfWork.CourseRepository.GetFirstOrDefaultAsync(c => c.ID == courseId);
        if (course == null) throw new KeyNotFoundException("Course not found.");

        await unitOfWork.CourseRepository.RemoveAsync(course);
        await unitOfWork.CompleteAsync();
        return Task.CompletedTask;
    }

    public async Task<WebApplication1.Entities.Models.Course> ViewCourse(int courseId) {
        var course = await unitOfWork.CourseRepository.GetFirstOrDefaultAsync(c => c.ID == courseId);
        if (course == null) throw new KeyNotFoundException("Course not found.");
        return course;
    }
}