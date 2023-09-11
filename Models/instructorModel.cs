


public enum Hello
{
    Instructor, Professor, AssistantProfessor, AssociateProfessor
}

public class Instructor
{

    public int id { get; set; }

    public string firstName { get; set; }
    public string lastName { get; set; }

    public bool isTenured { get; set; }
    public DateTime instructorDateHired { get; set; }
    public Hello instructorRank { get; set; }


}