using Microsoft.AspNetCore.Identity;

public class Users : IdentityUser
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }

}