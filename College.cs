namespace Assignment2;

public class College
{
    private Dictionary<int, Course> _courses = new();

    public College()
    {
    }

    void AddCourse(Course course) => _courses.Add(course.GetCourseId(), course);

    void AddStudentToCourse(int courseId, Student studentId) => _courses[courseId].EnrollStudent(studentId);


    //2d array holding something or other

    //method to return all students
    // maybe make a option menu for choosing students?

    //method to return student count and course count
}