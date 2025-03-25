namespace Assignment2;

public class Student {
    private static int studentCounter;
    private int studentId;
    private string name;
    private string emailAddress;

    public Student(string name, string emailAddress) {
        this.name = name;
        this.emailAddress = emailAddress;
        studentCounter++;
        studentId = studentCounter;
    }
}