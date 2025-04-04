using System.Text.Json.Serialization; //imports json serializer

namespace Assignment2;

public class Student
{
    private static int _studentCounter;
    [JsonInclude] private int _studentId;
    [JsonInclude] private string _name;
    [JsonInclude] private string _emailAddress; 
    // ^^^^^^^^^ <---- include's these as a json object's 
    
    public Student(string name, string emailAddress)
    {
        _name = name;
        _emailAddress = emailAddress;
        _studentCounter++;
        _studentId = _studentCounter;
    } //create's student when you only enter name and email

    public Student()
    {
        _name = "Unnamed";
        _emailAddress = "No Email Address";
        _studentCounter++;
        _studentId = _studentCounter;
    } // if you dont enter anything it makes you a default  object

    public Student(string name)
    {
        _name = name;
        _emailAddress = "No Email";
        _studentCounter++;
        _studentId = _studentCounter;
    } // creates student when you only add name

    //Gets
    public int GetStudentId()
    {
        return _studentId;
    } // return's student id

    public string GetName()
    {
        return _name;
    } // returns student name

    public string GetEmailAddress()
    {
        return _emailAddress;
    } // return students email

    //Sets
    public void SetName(string name)
    {
        _name = name;
    } // sets/changes student name

    public void SetEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
    } // sets/changes student name

    public override string ToString()
    {
        return "\n\tStudent Name: " + _name + "\n\tStudent ID: " + _studentId + "\n\tStudent Email: " + _emailAddress;
    } // return specified string when  object ref called
}