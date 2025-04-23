using FirstStepIntoMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using FirstStepIntoMVC.Models;

namespace FirstStepIntoMVC.Controllers;

public class StudentController : Controller {
    private IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentRepository) {
        _studentRepository = studentRepository;
    }


    public IActionResult GetStudentById(int id) {
        
        // this will return "try ViewData" when you call ViewBag.Message or ViewData["message"] 
        // Because ViewBag is just a wrapper to ViewData "Using dynamic" 
        
        // ViewBag and ViewData's lifetime that only spans the current request
        ViewBag.Message = "Try ViewBag";
        ViewData["message"] = "Try ViewData";

        // Will return "Try TempData" .
        // TempData persists across requests, and it's only cleared when you read it.
        TempData["message"] = "Try TempData";

        return View("index", _studentRepository.GetById(id));
    }
}