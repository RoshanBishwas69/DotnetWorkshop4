namespace workshop4;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "Stephen";
        s1.Age = 25;

        Student s2 = new Student();
        s2.Name = "kim Jong Un";
        s2.Age = 50;

        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("School: " + Student.SchoolName);

        Console.WriteLine("Student 2:");
        Console.WriteLine("Name: " + s2.Name);
        Console.WriteLine("Age: " + s2.Age);
        Console.WriteLine("School: " + Student.SchoolName);
    }
}