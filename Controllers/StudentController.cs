using System.Diagnostics;
using database.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RembulatITELEC1C.Models;


namespace RembulatITELEC1C.Controllers;



public class StudentController : Controller
{



    private readonly Database mssql;

    public StudentController(Database dummayData)
    {
        mssql = dummayData;
    }
    [Authorize]
    public IActionResult Index()
    {


        return View(mssql.Students);
    }
    public IActionResult ShowDetails(int id)
    {
        Student? student = mssql.Students.FirstOrDefault(t => t.studentID == id);

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

        if (!ModelState.IsValid)
        {
            return View();
        }
        mssql.Students.Add(newstudent);
        mssql.SaveChanges();
        return RedirectToAction("index");
    }
    public IActionResult updatestudent(int id)
    {

        Student? student = mssql.Students.FirstOrDefault(t => t.studentID == id);


        if (student != null)
        {
            return View(student);
        }
        return NotFound();
    }
    [HttpPost]
    public IActionResult updatestudent(Student updatestudent)
    {
        Student? student = mssql.Students.FirstOrDefault(t => t.studentID == updatestudent.studentID);


        if (!ModelState.IsValid)
        {
            return View();
        }
        if (student != null)
        {
            student.studentName = updatestudent.studentName;
            student.studentEmail = updatestudent.studentEmail;
            student.studentCourse = updatestudent.studentCourse;
            student.DateEndrolled = updatestudent.DateEndrolled;
            mssql.SaveChanges();
        };

        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult deletestudent(int id)
    {
        Student? student = mssql.Students.FirstOrDefault(t => t.studentID == id);


        return View(student);


    }

    [HttpPost]
    public IActionResult deletestudent(Student currentStudent)
    {
        Student? student = mssql.Students.FirstOrDefault(t => t.studentID == currentStudent.studentID);

        if (student != null)

            mssql.Students.Remove(student);
        mssql.SaveChanges();


        return RedirectToAction("index");
    }
}