using System.Text.Json.Serialization;

namespace Assignment2;

public class Student {
    private static int studentCounter ;
    [JsonInclude]
    private int studentId;
    [JsonInclude]
    private string name;
    [JsonInclude]
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
        return "\n  Student Name: " + name + "\n  Student ID: " + studentId + "\n  Student Email: " + emailAddress;
    }
}