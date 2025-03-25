namespace Assignment2;

internal static class Program
{
    internal static void Main()
    {
        Menu? menu = null;
        menu = new("Parent menu", new()
        {
            ["1"] = MenuOption.FromAction(() => Console.WriteLine("Hello There")),
            ["2"] = MenuOption.FromSubmenu(new("Submenu", new()
                    {
                        ["1"] = MenuOption.FromAction(() => Console.WriteLine("General Kenobi")),
                        ["b"] = MenuOption.FromAction(() => menu.Pop())
                    }
                )
            )
        });

        while (true)
        {
            menu.Display();
            menu.SelectOption(Console.ReadLine());
        }
    }
}