namespace Assignment2;

public class College
{
    public List<Student> students = new();
    private Dictionary<int, Course> _courses = new();

    public College() {
    }

    void AddCourse(Course course) => _courses.Add(course.GetCourseId(), course);

    void AddStudentToCourse(int courseId, Student studentId) => _courses[courseId].EnrollStudent(studentId);


    //Helper
    public void EnrollStudent() {
        Console.WriteLine("what is this students name?");
        string name = Console.ReadLine();
        Console.WriteLine("what is this students email?");
        string email = Console.ReadLine();
        
        students.Add(new Student(name, email));
    }
    //2d array holding something or other

    //method to return all students
    // maybe make a option menu for choosing students?

    //method to return student count and course count
}