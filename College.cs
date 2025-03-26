namespace Assignment2;

public class College
{
    public Dictionary<int, Student> students = new();
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

    public void AddStudentToCourse() {
        //print courses
        Console.WriteLine("courses: ");
        foreach (var course in _courses) {
            Console.WriteLine($"{course.Key}, {course.Value.GetCourseName()}");
        }
        Console.WriteLine("enter course you number you would like to add students too.");
        int courseId = int.Parse(Console.ReadLine()!);
        
        //print students
        Console.WriteLine("Students:");
        foreach (var a in students) {
            Console.WriteLine(a.Value.GetStudentID());
        }
        Console.WriteLine("what Student would you like to add?");
        int studentSelection = Int32.Parse(Console.ReadLine()!);
        
        _courses[courseId].EnrollStudent(students[studentSelection]);
    }

    //Helper
    public void EnrollStudent() {
        Console.Write("what is this students name?: ");
        var name = Console.ReadLine()!;
        Console.Write("what is this students email?: ");
        var email = Console.ReadLine()!;
        
        Student tempS = new Student(name, email);
        students.Add(tempS.GetStudentID() ,tempS);
    }

    public void DisplayStudents() {
        Console.WriteLine("Students:");
        foreach (var i in students) {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }
    }

    public void DisplayCourses() {
        Console.WriteLine("Students:");
        foreach (var i in _courses) {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }
    }
}