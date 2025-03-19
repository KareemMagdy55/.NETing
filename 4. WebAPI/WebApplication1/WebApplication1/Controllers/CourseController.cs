using WebApplication1.Service.Course;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities.Models;

namespace WebApplication1.Controllers;

[Route("/course")]
[ApiController]
public class CourseController : ControllerBase {
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService) {
        _courseService = courseService;
    }
    
    [HttpGet("courses/view/{courseId}")]
    public async Task<IActionResult> ViewCourse(int courseId) =>
        Ok(await _courseService.ViewCourse(courseId));

    [HttpPut("courses/update/{courseId}")]
    public async Task<IActionResult> UpdateCourse(int courseId, Course course) =>
        Ok(await _courseService.UpdateCourseAsync(courseId, course));
    
    [HttpPost("courses/add")]
    public async Task<IActionResult> AddCourse(Course course) =>
        Ok(await _courseService.AddCourseAsync(course));

    [HttpDelete("courses/delete/{course_id}")]
    public async Task<IActionResult> DeleteCourse(int courseId) =>
        Ok(await _courseService.DeleteCourseAsync(courseId));
    
        
}