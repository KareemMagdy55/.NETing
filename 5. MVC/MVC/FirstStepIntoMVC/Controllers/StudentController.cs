using FirstStepIntoMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using FirstStepIntoMVC.Models;

namespace FirstStepIntoMVC.Controllers;

public class StudentController : Controller {
    private IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentRepository) {
        this._studentRepository = studentRepository;
    }


    public IActionResult GetStudentById(int id) => View("index", _studentRepository.GetById(id));
}