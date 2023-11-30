

using System.ComponentModel.DataAnnotations;



public class LoginViewModel
{

    [Display(Name = "Username")]
    [Required(ErrorMessage = "username is required")]
    public string Username { get; set; }

    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]

    public string Password { get; set; }

    [Display(Name = "RememberMe")]
    public bool RememberMe { get; set; }
}