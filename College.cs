using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Int32;

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

        if (!TryParse(Console.ReadLine(), out var hours))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("invalid hours entry");
            Console.ResetColor();
            return;
        }

        Course c = new(name, hours);
        _courses.Add(c.GetCourseId(), c);
        Console.Clear();
    }

    public void AddStudentToCourse()
    {
        if (_courses.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("there are currently no courses to add students to");
            Console.ResetColor();
            return;
        }

        if (_students.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("there are currently no students to add to the existing courses");
            Console.ResetColor();
            return;
        }

        //print courses
        Console.WriteLine("Courses: ");
        foreach (var c in _courses)
        {
            Console.WriteLine($"{c.Key}, {c.Value.GetCourseName()}");
        }

        Console.Write("Enter number of the course you would like to add a student to: ");

        if (!TryParse(Console.ReadLine(), out var courseId))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("invalid string entry: course ID should be a number");
            Console.ResetColor();
            return;
        }

        if (!_courses.TryGetValue(courseId, out var course))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("no course with specified ID was found");
            Console.ResetColor();
            return;
        }

        //print students
        Console.WriteLine("Students:");
        foreach (var a in _students)
        {
            Console.WriteLine(a.Value.GetStudentId());
        }

        Console.Write("What student would you like to add?: ");

        if (!TryParse(Console.ReadLine(), out var studentId))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("invalid string entry: student ID should be a number");
            Console.ResetColor();
            return;
        }

        if (!_students.TryGetValue(studentId, out var student))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("no student with specified ID was found");
            Console.ResetColor();
            return;
        }

        course.EnrollStudent(student);
        Console.Clear();
    }

    //Helper
    public void EnrollStudent()
    {
        Console.Write("What is this student's name?: ");
        var name = Console.ReadLine()!;
        Console.Write("What is this student's email?: ");
        var email = Console.ReadLine()!;

        var tempS = new Student(name, email);
        _students.Add(tempS.GetStudentId(), tempS);
        Console.Clear();
    }

    public void DisplayStudents()
    {
        if (_students.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("there are no students to display");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("Students:");
        foreach (var i in _students)
        {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }

        Console.WriteLine();
    }

    public void DisplayCourses()
    {
        if (_students.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("there are no courses to display");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("Courses:");
        foreach (var i in _courses)
        {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }

        Console.WriteLine();
    }

    public void DisplayRegistration()
    {
        if (_courses.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("there are no courses to display");
            Console.ResetColor();
            return;
        }

        foreach (var course in _courses)
        {
            Console.WriteLine($"Course Name: {course.Value.GetCourseName()}");
            course.Value.DisplayStudentsString();
            if (course.Value.GetStudents().Count == 0)
            {
                Console.WriteLine("\tNo enrolled students\n");
            }
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