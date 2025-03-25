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
    public Student()
    {
        name = "Unnamed";
        emailAddress = "No Email Address";
        studentCounter++; 
        studentId = studentCounter;
    }
    public Student(string name)
    {
        this.name = name;
        emailAddress = "No Email";
        studentCounter++;
        studentId = studentCounter;
    }
    
    //Gets
    public int GetStudentID() {
        return studentId;
    }
    public string GetName() {
        return name;
    }
    public string GetEmailAddress() {
        return emailAddress;
    }
    
    //Sets
    public void SetName(string name) {
        this.name = name;
    }
    public void SetEmailAddress(string emailAddress) {
        this.emailAddress = emailAddress;
    }

    public override string ToString() {
        return "Student Name: " + name + "\nStudent ID: " + studentId + "\nStudent Email: " + emailAddress;
    }
}