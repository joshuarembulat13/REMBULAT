


public enum Hello
{
    Instructor, Prof, AsstProf
}

public class Instructor
{
    public string instructorID { get; set; }

    public string instructorName { get; set; }
    public string instructorEmail { get; set; }
    public DateTime instructorDateHired { get; set; }
    public Hello instructorRank { get; set; }


}