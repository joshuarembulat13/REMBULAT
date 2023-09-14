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

    List<Student> StudentsList = new List<Student>() {
                    new Student() {
                        studentID= 1,
                        studentName= "Joshua Rembulat",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "joshua.rembulat.cics@ust.edu.ph"
                    },

                    new Student() {
                        studentID= 2,
                        studentName= "EJ Monteclaro",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "elpidio.monteclaro.cics@ust.edu.ph"
                    },

                    new Student() {
                        studentID= 3,
                        studentName= "Leannard Ramos",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "lennard.ramos.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 4,
                        studentName= "Phoebe Ngitngit",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "alexisphoebe.ngitngi.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 4,
                        studentName= "Jasper Noel Llave",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "jaspernodel.llave.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 5,
                        studentName= "Jean Stefanie Khaldyn Abarquez",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "jeanstafanie.abarquez.cics@ust.edu.ph"
                    },
                     new Student() {
                        studentID= 6,
                        studentName= "Azzilhea Angel Samson",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "azzilheaangel.samson.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 7,
                        studentName= "Antonio Criscencio Arrieta",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "antoniocriscencio.arrieta.cics@ust.edu.ph"
                    },
                     new Student() {
                        studentID= 8,
                        studentName= "Micko Tee",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "micko.tee.cics@ust.edu.ph"
                    },

                };

    public IActionResult Index()
    {


        return View(StudentsList);
    }
    public IActionResult ShowDetails(int id)
    {
        Student? student = StudentsList.FirstOrDefault(t => t.studentID == id);

        if (student != null)
        {
            return View(student);
        }
        return NotFound();
    }
    [HttpGet]
    public IActionResult addstudent()
    {
        return View();
    }
    [HttpPost]
    public IActionResult addstudent(Student newstudent)
    {

        StudentsList.Add(newstudent);
        return View("Index", StudentsList);
    }
}