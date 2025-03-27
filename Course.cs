using System.Text.Json.Serialization;

namespace Assignment2;

public class Course
{
    private static int _courseCounter;
    [JsonInclude] private int _courseId;
    [JsonInclude] private string _courseName;
    [JsonInclude] private double _courseHours;
    [JsonInclude] private List<Student> _students = [];

    public Course(string courseName, double courseHours)
    {
        _courseName = courseName;
        _courseHours = courseHours;
        _courseId = ++_courseCounter;
    }

    public Course(string courseName)
    {
        _courseName = courseName;
        _courseHours = 0;
        _courseId = ++_courseCounter;
    }

    public Course(double courseHours)
    {
        _courseName = "unnamed";
        _courseHours = courseHours;
        _courseId = ++_courseCounter;
    }

    public Course()
    {
        _courseName = "unnamed";
        _courseHours = 0;
        _courseId = ++_courseCounter;
    }

    // GETS
    public int GetCourseId()
    {
        return _courseId;
    }

    public string GetCourseName()
    {
        return _courseName;
    }

    public double GetCourseHours()
    {
        return _courseHours;
    }

    public List<Student> GetStudents() => _students;


    // SETS
    public void SetCourseName(string newCourseName)
    {
        _courseName = newCourseName;
    }

    public void SetCourseHours(double newCourseHours)
    {
        _courseHours = newCourseHours;
    }

    // Helpers
    public void EnrollStudent(Student student)
    {
        _students.Add(student);
    }

    public void DisplayStudentsString()
    {
        Console.WriteLine($"Students of {_courseName}:");
        foreach (var student in _students)
        {
            Console.WriteLine($"{student}\n");
        }
    }

    public override string ToString()
    {
        return "\n\tCourse name: " + _courseName + "\n\tCourse ID: " + _courseId + "\n\tCourse hours: " +
               _courseHours;
    }
}