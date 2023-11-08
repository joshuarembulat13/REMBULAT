
using System.ComponentModel.DataAnnotations;


public enum Course
{
    BSIT, BSCS, BSIS
}
public class Student
{

    [Key]
    public int studentID { get; set; }
    [Display(Name = "Student Name")]
    [Required(ErrorMessage = "Student Name is required")]
    public string studentName { get; set; }
    [Display(Name = "Date Enrolled")]
    [Required(ErrorMessage = "Date Enrolled is required")]
    [DataType(DataType.DateTime)]
    public DateTime DateEndrolled { get; set; }
    [Display(Name = "Student Course")]
    [Required(ErrorMessage = "Student Course is required")]
    public Course studentCourse { get; set; }
    [Display(Name = "Student Email")]
    [Required(ErrorMessage = "Email Address is required")]
    [EmailAddress]
    public string studentEmail { get; set; }



}