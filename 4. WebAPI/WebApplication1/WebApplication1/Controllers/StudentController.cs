using WebApplication1.Service.Course;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities.Models;
using WebApplication1.Service.Student;

namespace WebApplication1.Controllers;

[Route("/student")]
[ApiController]
public class StudentController : ControllerBase {
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService) {
        _studentService = studentService;
    }
    
    [HttpGet("students/view/{studentId}")]
    public async Task<IActionResult> ViewStudent(int studentId) =>
        Ok(await _studentService.ViewStudent(studentId));

    [HttpPut("students/update/{studentId}")]
    public async Task<IActionResult> UpdateStudent(int studentId, Student student) =>
        Ok(await _studentService.UpdateStudentAsync(studentId, student));
    
    [HttpPost("students/add")]
    public async Task<IActionResult> AddStudent(Student student) =>
        Ok(await _studentService.AddStudentAsync(student));

    [HttpDelete("students/delete/{studentId}")]
    public async Task<IActionResult> DeleteStudent(int studentId) =>
        Ok(await _studentService.DeleteStudentAsync(studentId));
    
        
}