using database.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace RembulatITELEC1C.Controllers;



public class InstructorController : Controller
{

  private readonly Database mssql;

  public InstructorController(Database dummayData)
  {
    mssql = dummayData;
  }
  [Authorize]
  public IActionResult Index()
  {
    return View(mssql.Instructors);
  }


  public IActionResult ShowDetails(int id)
  {


    Instructor? instructors = mssql.Instructors.FirstOrDefault(t => t.id == id);

    if (instructors != null)
    {
      return View(instructors);
    }
    return NotFound();
  }

  [HttpGet]
  public IActionResult addinstructor()
  {
    return View();
  }

  [HttpPost]
  public IActionResult addinstructor(Instructor newinstructor)
  {

    if (!ModelState.IsValid)
    {
      return View();
    }
    mssql.Instructors.Add(newinstructor);
    mssql.SaveChanges();
    return View("Index", mssql.Instructors);
  }
  public IActionResult updateinstructor(int id)
  {

    Instructor? student = mssql.Instructors.FirstOrDefault(t => t.id == id);

    if (student != null)
    {
      return View(student);
    }
    return NotFound();
  }
  [HttpPost]
  public IActionResult updateinstructor(Instructor updateinstructor)
  {
    Instructor? instructor = mssql.Instructors.FirstOrDefault(t => t.id == updateinstructor.id);



    if (instructor != null)
    {

      if (!ModelState.IsValid)
      {
        return View();
      }
      instructor.firstName = updateinstructor.firstName;
      instructor.lastName = updateinstructor.lastName;
      mssql.SaveChanges();

    };

    return View("Index", mssql.Instructors);
  }

  [HttpGet]
  public IActionResult deleteinstructor(int id)
  {
    Instructor? instructor = mssql.Instructors.FirstOrDefault(t => t.id == id);


    return View(instructor);


  }

  [HttpPost]
  public IActionResult deleteinstructor(Instructor currentInstructor)
  {
    Instructor? instructor = mssql.Instructors.FirstOrDefault(t => t.id == currentInstructor.id);

    if (instructor != null)

      mssql.Instructors.Remove(instructor);
    mssql.SaveChanges();

    return View("Index", mssql.Instructors);
  }

}