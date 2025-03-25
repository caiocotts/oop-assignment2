namespace Assignment2;

public class College
{
    public List<Student> students = new();
    private Dictionary<int, Course> _courses = new();

    public College() {
    }

    public void AddCourse()
    {
        Console.Write("Course name: ");
        var name = Console.ReadLine()!;
        
        Console.Write("Total course hours: ");
        var hours = int.Parse(Console.ReadLine()!); 
        
        // _courses.Add(course.GetCourseId(), course);

        Course c = new(name, hours); 
        _courses.Add(c.GetCourseId(), c);
    }

    public void AddStudentToCourse(int courseId, Student studentId) => _courses[courseId].EnrollStudent(studentId);


    //Helper
    public void EnrollStudent() {
        Console.Write("what is this students name?: ");
        var name = Console.ReadLine()!;
        Console.Write("what is this students email?: ");
        var email = Console.ReadLine()!;
        
        students.Add(new(name, email));
    }
}