using System.Text.Json.Serialization;

namespace Assignment2;

public class Course
{
    private static int _courseCounter;
    [JsonInclude] private int _courseId;
    [JsonInclude] private string _courseName;
    [JsonInclude] private double _courseHours;
    [JsonInclude] private List<Student> _students = [];
    // ^^^^^^^^^ <---- include's these as a json object's 
    
    public Course(string courseName, double courseHours)
    {
        _courseName = courseName;
        _courseHours = courseHours;
        _courseId = ++_courseCounter;
    } // creates course when you only put name and hours

    public Course(string courseName)
    {
        _courseName = courseName;
        _courseHours = 0;
        _courseId = ++_courseCounter;
    } // makes course when you only provide name

    public Course(double courseHours)
    {
        _courseName = "unnamed";
        _courseHours = courseHours;
        _courseId = ++_courseCounter;
    } // makes course when you only provide course hours

    public Course()
    {
        _courseName = "unnamed";
        _courseHours = 0;
        _courseId = ++_courseCounter;
    } // creates default course

    // GETS
    public int GetCourseId()
    {
        return _courseId;
    } // return course ID(primary key)

    public string GetCourseName()
    {
        return _courseName;
    } // returns course name

    public double GetCourseHours()
    {
        return _courseHours;
    } // returns course hours

    public List<Student> GetStudents() => _students; // students list


    // SETS
    public void SetCourseName(string newCourseName)
    {
        _courseName = newCourseName;
    } // set/change course name

    public void SetCourseHours(double newCourseHours)
    {
        _courseHours = newCourseHours;
    } // set/change course hours

    // Helpers
    public void EnrollStudent(Student student)
    {
        _students.Add(student);
    } // enrolls a student in a class

    public void DisplayStudentsString()
    {
        Console.WriteLine($"Students of {_courseName}:");
        foreach (var student in _students)
        {
            Console.WriteLine($"{student}\n");
        }
    } // displays students in each course

    public override string ToString()
    {
        return "\n\tCourse name: " + _courseName + "\n\tCourse ID: " + _courseId + "\n\tCourse hours: " +
               _courseHours;
    } // prints specified string when you call object name for print
}