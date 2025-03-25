namespace Assignment2;

/// <summary>
/// Represents a menu option which a user can select. Could be an Action or another menu.
/// </summary>
public class MenuOption(Action? action, Menu? subMenu)
{
    public Action? Action { get; } = action;
    public Menu? SubMenu { get; } = subMenu;

    /// <summary>
    ///   Creates a new MenuOption object with the action passed as a parameter. The submenu will be null.
    /// </summary>
    /// <param name="action"></param>
    /// <returns>An action to be executed by the user upon selection</returns>
    public static MenuOption FromAction(Action action) => new(action, null);

    /// <summary>
    ///   Creates a new MenuOption object with the submenu passed as a parameter. The action will be null.
    /// </summary>
    /// <param name="submenu"></param>
    /// <returns>A submenu which can be navigated into upon selection</returns>
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
        if (string.IsNullOrEmpty(selection) || !MenuOptions.TryGetValue(selection, out var option))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid entry");
            Console.ResetColor();
            return;
        }

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