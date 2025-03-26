namespace Assignment2;

internal static class Program
{
    internal static void Main()
    {
        var college = new College();
        
        if (File.Exists("data.json")) college.Load();

        Menu? menu = null;
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
                ["3"] = MenuOption.FromAction(() => college.AddStudentToCourse()),
                ["4"] = MenuOption.FromAction(() => college.DisplayStudents()),
                ["5"] = MenuOption.FromAction(() => college.DisplayCourses()),
                ["6"] = MenuOption.FromAction(() => college.DisplayRegistration()),
                ["7"] = MenuOption.FromAction(() => college.Save()),
                ["8"] = MenuOption.FromAction(() => college.Load()),
                ["9"] = MenuOption.FromAction(() => menu.Pop())
            });
        

        while (true)
        {
            menu.Display();
            menu.SelectOption(Console.ReadLine());
        }
    }
}