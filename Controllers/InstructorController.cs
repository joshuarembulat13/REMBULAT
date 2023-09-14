using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RembulatITELEC1C.Models;


namespace RembulatITELEC1C.Controllers;



public class InstructorController : Controller
{

  private readonly ILogger<InstructorController> _logger;

  public InstructorController(ILogger<InstructorController> logger)
  {
    _logger = logger;
  }

  List<Instructor> instructorsList = new List<Instructor>() {
                    new Instructor(){
                        id = 1,
                        firstName=  "Ronina",
                        lastName= "Tayuan",
                        isTenured =true,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssistantProfessor,
                      },
                    new Instructor(){
                        id = 2,
                        firstName = "Maricel",
                        lastName = "Balais",
                        isTenured = false,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssociateProfessor
                      },
                        new Instructor(){
                        id = 3,
                        firstName ="Jerralyn",
                        lastName ="Padua",
                        isTenured = true,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssociateProfessor
                      },

                };

  public IActionResult Index()
  {
    return View(instructorsList);
  }


  public IActionResult ShowDetails(int id)
  {


    Instructor instructors = instructorsList.FirstOrDefault(t => t.id == id);

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
    instructorsList.Add(newinstructor);
    return View("Index", instructorsList);
  }
}