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
    public IActionResult Index()
    {


        List<Instructor> instructorsList = new List<Instructor>() {
                    new Instructor(){
                        instructorID = "1",
                        instructorEmail=  "montanogab@gmail.caom",
                        instructorName = "Gab Montano",
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.Instructor,
                      },
                    new Instructor(){
                        instructorID = "2",
                        instructorEmail=  "miaelazaur@gmail.com",
                        instructorName = "Mia Elazaur",
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.Prof
                      },
                        new Instructor(){
                        instructorID = "3",
                        instructorEmail=  "Lintagleo@gmail.com",
                        instructorName = "Leo Lintag",
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AsstProf
                      },

                };


        return View(instructorsList);
    }
}