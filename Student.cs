namespace Assignment2;

public class Student {
    private static int studentCounter;
    private int studentID;
    private string name;
    private string enrolledCourses;

    public Student(string name, string enrolledCourses) {
        this.name = name;
        this.enrolledCourses = enrolledCourses;
        studentCounter++;
        studentID = studentCounter;
    }
}