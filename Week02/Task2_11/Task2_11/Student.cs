public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student()
    {
    }

    public override string ToString()
    {
        return $"Student: {Id} - {Name}";
    }
}