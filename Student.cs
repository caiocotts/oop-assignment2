using System.Text.Json.Serialization; //imports json serializer

namespace Assignment2;

public class Student
{
    private static int _studentCounter;
    [JsonInclude] private int _studentId;
    [JsonInclude] private string _name;
    [JsonInclude] private string _emailAddress;

    public Student(string name, string emailAddress)
    {
        _name = name;
        _emailAddress = emailAddress;
        _studentCounter++;
        _studentId = _studentCounter;
    }

    public Student()
    {
        _name = "Unnamed";
        _emailAddress = "No Email Address";
        _studentCounter++;
        _studentId = _studentCounter;
    }

    public Student(string name)
    {
        _name = name;
        _emailAddress = "No Email";
        _studentCounter++;
        _studentId = _studentCounter;
    }

    //Gets
    public int GetStudentId()
    {
        return _studentId;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmailAddress()
    {
        return _emailAddress;
    }

    //Sets
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
    }

    public override string ToString()
    {
        return $"""
        	Student ID: {_studentId}
        	Student Name: {_name}
        	Student Email: {_emailAddress}
        """;
    }
}