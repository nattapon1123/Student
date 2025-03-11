public class Person
{
    public string FullName { get; set; }
    public string Major { get; set; }

    public Person(string fullName, string major)
    {
        FullName = fullName;
        Major = major;
    }
}
