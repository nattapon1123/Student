public class Student : Person
{
    public string StudentID { get; set; }
    public double GPA { get; set; }
    public Advisor Advisor { get; set; }

    public Student(string studentID, string fullName, string major, Advisor advisor, double gpa)
        : base(fullName, major)
    {
        StudentID = studentID;
        GPA = gpa;
        Advisor = advisor;
    }
}
