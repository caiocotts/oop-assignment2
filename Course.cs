namespace Assignment2;

public class Course {
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

    // GETS
    public int getCourseID() {
        return courseID;
    }
    public string getCourseName() {
        return courseName;
    }
    public double getCourseHours() {
        return courseHours;
    }
    
    // SETS
    public void setCourseName(string courseName) {
        this.courseName = courseName;
    }
    public void setCourseHours(double courseHours) {
        this.courseHours = courseHours;
    }
}