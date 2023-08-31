using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RembulatITELEC1C.Models;


namespace RembulatITELEC1C.Controllers;



public class StudentController : Controller
{

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {

        Student student = new Student();

        student.studentID = "2019131071";

        student.studentName = "Rembulat, Joshua R.";
        student.studentCourse = Course.BSIT;
        student.studentEmail = "joshua.rembulat.cics@ust.edu.ph";
        student.DateEndrolled = DateTime.Parse("08/30/2023").Date;

        ViewBag.Student = student.studentID;
        ViewBag.StudentName = student.studentName;
        ViewBag.StudentCourse = student.studentCourse;
        ViewBag.StudentEmail = student.studentEmail;
        ViewBag.StudentDateEnrolled = student.DateEndrolled;


        return View();
    }
}