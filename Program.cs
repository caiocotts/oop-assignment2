//Name: O'Neal Jean, Caio Cotts, Keagan Cameron 
//Student ID: O'Neal's Student ID: 101-544-778 || Caio's Student ID: 101-571-045 || Keagan's Student ID: 101-543-441 

namespace Assignment2;

internal static class Program
{
    internal static void Main()
    {
        Console.Clear();
        var college = new College();

        if (File.Exists("data.json")) college.Load(); // load data from a json file

        // Create a new menu (Menu library documentation is in Menu.cs)
        Menu? menu = null;
        menu = new(
            """
            - - - - Registration - - - -
            1 - Register new student
            2 - Register a new course
            3 - Enroll a student in a course
            
            - - - - Display - - - -
            4 - Display all students
            5 - Display all courses
            6 - Display registrations
            
            - - - - Data - - - -
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
                ["6"] = MenuOption.FromAction(() => college.DisplayRegistration()), // display all courses and the students in them
                ["7"] = MenuOption.FromAction(() => college.Save()), // saves college data to a json file
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