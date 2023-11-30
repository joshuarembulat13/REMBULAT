

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
public class AccountController : Controller
{

    private readonly SignInManager<Users> _signManager;
    private readonly UserManager<Users> _userManager;

    public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager)
    {
        _signManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel loginInfo)
    {
        var result = await _signManager.PasswordSignInAsync(loginInfo.Username, loginInfo.Password, loginInfo.RememberMe, false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Instructor");
        }
        else
        {
            ModelState.AddModelError("", "Failed to login");
        }
        return View(loginInfo);
    }

    public async Task<IActionResult> Logout()
    {
        await _signManager.SignOutAsync();
        return RedirectToAction("Index", "Instructor");
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterModelView userEnteredData)
    {
        Users newUser = new Users();

        newUser.UserName = userEnteredData.Username;
        newUser.Firstname = userEnteredData.FirstName;
        newUser.Lastname = userEnteredData.LastName;
        newUser.Email = userEnteredData.EmailAddress;
        newUser.PhoneNumber = userEnteredData.Phonenumber;

        var result = await _userManager.CreateAsync(newUser, userEnteredData.Password);

        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Instructor");
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        return View(userEnteredData);

    }

}


