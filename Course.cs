using System.Text.Json.Serialization;

namespace Assignment2;

public class Course {
    private static int courseCounter;
    [JsonInclude]
    private int courseID;
    [JsonInclude]
    private string courseName;
    [JsonInclude]
    private double courseHours;
    [JsonInclude]
    private List<Student> students = [];
    public Course (string courseName, double courseHours) {
        this.courseName = courseName;
        this.courseHours = courseHours;
        courseID++;
    } 
    public Course(string courseName) {
        this.courseName = courseName;
        courseHours = 0;
        courseID++;
    }
    public Course(double courseHours) {
        courseName = "unnamed";
        this.courseHours = courseHours;
        courseID++;
    }
    public Course() {
        courseName = "unnamed";
        courseHours = 0;
        courseID++;
    }

    // GETS
    public int GetCourseId() {
        return courseID;
    }
    public string GetCourseName() {
        return courseName;
    }
    public double GetCourseHours() {
        return courseHours;
    }

    public void getStudentsString() {
        Console.WriteLine($"Students of {courseName}:");
        foreach (Student student in students) {
            Console.WriteLine(student);
        }
    }
    
    // SETS
    public void SetCourseName(string newCourseName) {
        courseName = newCourseName;
    }
    public void SetCourseHours(double newCourseHours) {
        courseHours = newCourseHours;
    }

    // Helpers
    public void EnrollStudent(Student student) {
        students.Add(student);
    }
    public override string ToString() {
        return "\n   Course name: " + courseName + "\n   Course ID: " + courseID + "\n   Course hours: " + courseHours;
    }
}