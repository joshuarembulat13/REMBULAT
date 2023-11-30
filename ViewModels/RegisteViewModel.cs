


using System.ComponentModel.DataAnnotations;

public class RegisterModelView
{
    [Display(Name = "usernamae")]
    [Required(ErrorMessage = "username is required")]
    public string? Username { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "please enter your password")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Email Address")]
    [Required(ErrorMessage = "Email Address is required")]
    public string EmailAddress { get; set; }
    [Display(Name = "Firstname")]
    [Required(ErrorMessage = "Firstname is required")]
    public string FirstName { get; set; }
    [Display(Name = "Lastname")]
    [Required(ErrorMessage = "Lastname is required")]
    public string LastName { get; set; }

    [Display(Name = "Phone number")]
    [Required(ErrorMessage = "Phone number is required")]

    public string Phonenumber { get; set; }
}