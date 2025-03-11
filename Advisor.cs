public class Advisor
{
    public string Name { get; set; }
    public string Department { get; set; }
    public List<Student> AdviseeList { get; set; }

    // Constructor
    public Advisor(string name, string department)
    {
        Name = name;
        Department = department;
        AdviseeList = new List<Student>();
    }

    // Method to add student
    public void AddStudent(Student student)
    {
        AdviseeList.Add(student);
    }

    // Override ToString to display more details in ComboBox
    public override string ToString()
    {
        return $"{Name} - {Department}";  // Display Name and Department in ComboBox
    }
}
