namespace Assignment2;

public class College {
    private Dictionary<int, Student> _students = new();
    private Dictionary<int, Course> _courses = new();

    College()
    {
    }

    void EnrollStudent(Student student) => _students.Add(student.GetStudentID(), student);

    void AddCourse(Course course) => _courses.Add(course.GetCourseId(), course);

    void AddStudentToCourse(int courseId, int studentId )
    {
    }
    
    
    //2d array holding something or other
    
    //method to return all students
    // maybe make a option menu for choosing students?
    
    //method to return student count and course count
    
}