



public enum Course
{
    BSIT, BSCS, BSIS
}
public class Student
{
    public string studentID { get; set; }
    public string studentName { get; set; }
    public DateTime DateEndrolled { get; set; }


    public Course studentCourse { get; set; }

    public string studentEmail { get; set; }

    

}