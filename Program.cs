
namespace Assignment2;

internal static class Program
{
    internal static void Main()
    {

        var college = new College();
        // college.EnrollStudent(); //Working
        // college.AddCourse(); //Working
        // college.AddStudentToCourse(); //doesnt work properly without atleast: 1 student & 1 Course
        // college.DisplayStudents(); //working
        // college.DisplayCourses(); //working

        /*Menu? menu = null;
        menu = new(
            """
            ------ Main Menu ------
            1 - Add new student
            2 - Add a new course
            3 - Register a user to a course
            4 - Display all students
            5 - Display all courses
            6 - Display registrations
            7 - Save data
            8 - Load data
            9 - Exit
            
            > 
            """, new()
            {
                ["1"] = MenuOption.FromAction(() => college.EnrollStudent()),
                ["2"] = MenuOption.FromAction(() => college.AddCourse()),
                ["3"] = MenuOption.FromAction(() => { }),
                ["4"] = MenuOption.FromAction(() => { }),
                ["5"] = MenuOption.FromAction(() => { }),
                ["6"] = MenuOption.FromAction(() => { }),
                ["7"] = MenuOption.FromAction(() => { }),
                ["8"] = MenuOption.FromAction(() => { }),
                ["9"] = MenuOption.FromAction(() => { })
            });
        
        while (true)
        {
            menu.Display();
            menu.SelectOption(Console.ReadLine());
        }*/
    }
}