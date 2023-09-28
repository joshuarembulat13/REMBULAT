using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RembulatITELEC1C.Models;


namespace RembulatITELEC1C.Controllers;



public class InstructorController : Controller
{

  private readonly DataInterfaceService _dummyData;

  public InstructorController(DataInterfaceService dummayData)
  {
    _dummyData = dummayData;
  }

  public IActionResult Index()
  {
    return View(_dummyData.instructorsList);
  }


  public IActionResult ShowDetails(int id)
  {


    Instructor? instructors = _dummyData.instructorsList.FirstOrDefault(t => t.id == id);

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
    _dummyData.instructorsList.Add(newinstructor);
    return View("Index", _dummyData.instructorsList);
  }
  public IActionResult updateinstructor(int id)
  {

    Instructor? student = _dummyData.instructorsList.FirstOrDefault(t => t.id == id);

    if (student != null)
    {
      return View(student);
    }
    return NotFound();
  }
  [HttpPost]
  public IActionResult updateinstructor(Instructor updateinstructor)
  {
    Instructor? instructor = _dummyData.instructorsList.FirstOrDefault(t => t.id == updateinstructor.id);

    if (instructor != null)
    {
      instructor.firstName = updateinstructor.firstName;
      instructor.lastName = updateinstructor.lastName;

    };

    return View("Index", _dummyData.instructorsList);
  }

  [HttpGet]
  public IActionResult deleteinstructor(int id)
  {
    Instructor? instructor = _dummyData.instructorsList.FirstOrDefault(t => t.id == id);


    return View(instructor);


  }

  [HttpPost]
  public IActionResult deleteinstructor(Instructor currentInstructor)
  {
    Instructor? instructor = _dummyData.instructorsList.FirstOrDefault(t => t.id == currentInstructor.id);

    if (instructor != null)

      _dummyData.instructorsList.Remove(instructor);


    return View("Index", _dummyData.instructorsList);
  }

}