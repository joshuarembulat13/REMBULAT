


using System.ComponentModel.DataAnnotations;

public enum Hello
{
    Instructor, Professor, AssistantProfessor, AssociateProfessor
}

public class Instructor
{


    [Key]
    public int id { get; set; }
    [Display(Name = "Firstname")]
    [Required(ErrorMessage = "Firstname is required")]
    public string firstName { get; set; }
    [Display(Name = "Lastname")]
    [Required(ErrorMessage = "Lastname is required")]
    public string lastName { get; set; }
    [Display(Name = "IsTenured")]
    [Required(ErrorMessage = "isTenured is required")]
    public bool isTenured { get; set; }



    [DataType(DataType.DateTime, ErrorMessage = "Date Hired Required")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd:hh:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime instructorDateHired { get; set; }
    [Display(Name = "Instructor Rank")]
    [Required(ErrorMessage = "Instructor Rank is required")]
    public Hello instructorRank { get; set; }

}