namespace Assignment2;

public class Course {
    private static int courseCounter;
    private int courseID;
    private string courseName;
    private double courseHours;
    
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
    
    // SETS
    public void SetCourseName(string newCourseName) {
        courseName = newCourseName;
    }
    public void SetCourseHours(double newCourseHours) {
        courseHours = newCourseHours;
    }

    public String toString() {
        return "Course name: " + courseName + "\nCourse ID: " + courseID + "\nCourse hours: " + courseHours;
    }
}