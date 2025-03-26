using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment2;

public class College
{
    [JsonInclude] private Dictionary<int, Student> _students = new();
    [JsonInclude] private Dictionary<int, Course> _courses = new();
    

    public void AddCourse()
    {
        Console.Write("Course name: ");
        var name = Console.ReadLine()!;

        Console.Write("Total course hours: ");
        var hours = int.Parse(Console.ReadLine()!);

        Course c = new(name, hours);
        _courses.Add(c.GetCourseId(), c);
    }

    public void AddStudentToCourse()
    {
        //print courses
        Console.WriteLine("courses: ");
        foreach (var course in _courses)
        {
            Console.WriteLine($"{course.Key}, {course.Value.GetCourseName()}");
        }

        Console.WriteLine("enter course you number you would like to add students too.");
        var courseId = int.Parse(Console.ReadLine()!);

        //print students
        Console.WriteLine("Students:");
        foreach (var a in _students)
        {
            Console.WriteLine(a.Value.GetStudentId());
        }

        Console.WriteLine("what Student would you like to add?");
        var studentSelection = int.Parse(Console.ReadLine()!);

        _courses[courseId].EnrollStudent(_students[studentSelection]);
    }

    //Helper
    public void EnrollStudent()
    {
        Console.Write("what is this students name?: ");
        var name = Console.ReadLine()!;
        Console.Write("what is this students email?: ");
        var email = Console.ReadLine()!;

        var tempS = new Student(name, email);
        _students.Add(tempS.GetStudentId(), tempS);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Students:");
        foreach (var i in _students)
        {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }
    }

    public void DisplayCourses()
    {
        Console.WriteLine("Courses:");
        foreach (var i in _courses)
        {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }
    }

    public void DisplayRegistration()
    {
        foreach (var course in _courses)
        {
            Console.WriteLine($"Course  {course.Value.GetCourseName()}");
            Console.WriteLine($"Student:");
            course.Value.DisplayStudentsString();
        }
    }

    public void Save() => File.WriteAllText("data.json", JsonSerializer.Serialize(this));

    public void Load()
    {
        var c = JsonSerializer.Deserialize<College>(File.ReadAllText("data.json"))!;
        _students = c._students;
        _courses = c._courses;
    }
}
//Testing 