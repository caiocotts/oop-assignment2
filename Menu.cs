namespace Assignment2;

public class MenuOption
{
    public Action? Action { get; }
    public Menu? SubMenu { get; }

    private MenuOption(Action? action, Menu? subMenu)
    {
        Action = action;
        SubMenu = subMenu;
    }

    public static MenuOption FromAction(Action action) => new(action, null);
    public static MenuOption FromSubmenu(Menu submenu) => new(null, submenu);
}

/// <summary>
/// Represents a terminal user interface menu, which has 0 or many options and submenus.
/// </summary>
/// <param name="menuString">A string that is used to display menu options to the console.</param>
/// <param name="menuOptions">A dictionary which holds each menu option what the user can select.</param>
public class Menu(string menuString, Dictionary<string, MenuOption> menuOptions)
{
    private Menu? _previousMenu;
    private string MenuString { get; set; } = menuString;
    private Dictionary<string, MenuOption> MenuOptions { get; set; } = menuOptions;

    /// <summary>
    /// Performs and action based on the user's selection. Either execute a function, or navigate to a submenu.
    /// </summary>
    /// <param name="selection">A string representing a menu selection made by the user.</param>
    public void SelectOption(string? selection)
    {
        Console.Clear();
        if (string.IsNullOrEmpty(selection) ||
            !MenuOptions
                .ContainsKey(selection)) //using out variables is an anti-pattern, so i'm using ContainsKey instead
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid entry");
            Console.ResetColor();
            return;
        }

        var option = MenuOptions[selection];
        if (option.Action != null) option.Action();
        else if (option.SubMenu != null)
        {
            _previousMenu = Clone();
            MenuString = option.SubMenu.MenuString;
            MenuOptions = option.SubMenu.MenuOptions;
        }
    }

    /// <summary>
    /// Clones a Menu object.
    /// </summary>
    /// <returns>A copy of the calling Menu object.</returns>
    private Menu Clone() => new(MenuString, MenuOptions);

    /// <summary>
    /// Display the menu string on the console.
    /// </summary>
    public void Display() => Console.Write(MenuString);

    /// <summary>
    /// Sets the current menu to the previous one. This will navigate up the menu structure by one position.
    /// If there is no previous menu, gracefully shutdown the program.
    /// </summary>
    public void Pop()
    {
        if (_previousMenu == null)
        {
            Console.WriteLine("Exiting program");
            Environment.Exit(0);
        }

        MenuString = _previousMenu.MenuString;
        MenuOptions = _previousMenu.MenuOptions;
        _previousMenu = _previousMenu._previousMenu;
    }
}