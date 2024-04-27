
class Student
{
    public string FirstName, LastName, Year, Course, Section;
    public float MidtermGrade, FinalGrade;

    public Student(string FirstName, string LastName, string Year, string Course, string Section, float MidtermGrade, float FinalGrade)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Year = Year;
        this.Course = Course;
        this.Section = Section;
        this.MidtermGrade = MidtermGrade;
        this.FinalGrade = FinalGrade;
    }

    public void introduceSelf()
    {
        Console.WriteLine($"I am {FirstName} {LastName}, {Course} {Year} section {Section}.");
    }

    public void evaluateGrade()
    {
        float average = (MidtermGrade + FinalGrade) / 2;
        Console.WriteLine("Average: " + average);
    }
}