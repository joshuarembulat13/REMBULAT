using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RembulatITELEC1C.Models;


namespace RembulatITELEC1C.Controllers;



public class StudentController : Controller
{



    private readonly DataInterfaceService _dummyData;

    public StudentController(DataInterfaceService dummayData)
    {
        _dummyData = dummayData;
    }

    public IActionResult Index()
    {


        return View(_dummyData.StudentsList);
    }
    public IActionResult ShowDetails(int id)
    {
        Student? student = _dummyData.StudentsList.FirstOrDefault(t => t.studentID == id);

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

        _dummyData.StudentsList.Add(newstudent);
        return RedirectToAction("index");
    }
    public IActionResult updatestudent(int id)
    {

        Student? student = _dummyData.StudentsList.FirstOrDefault(t => t.studentID == id);

        if (student != null)
        {
            return View(student);
        }
        return NotFound();
    }
    [HttpPost]
    public IActionResult updatestudent(Student updatestudent)
    {
        Student? student = _dummyData.StudentsList.FirstOrDefault(t => t.studentID == updatestudent.studentID);

        if (student != null)
        {
            student.studentName = updatestudent.studentName;
            student.studentEmail = updatestudent.studentEmail;
            student.studentCourse = updatestudent.studentCourse;
        };

        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult deletestudent(int id)
    {
        Student? student = _dummyData.StudentsList.FirstOrDefault(t => t.studentID == id);


        return View(student);


    }

    [HttpPost]
    public IActionResult deletestudent(Student currentStudent)
    {
        Student? student = _dummyData.StudentsList.FirstOrDefault(t => t.studentID == currentStudent.studentID);

        if (student != null)

            _dummyData.StudentsList.Remove(student);


        return RedirectToAction("index");
    }
}