using EntityOOP.GameFramework;
using EntityOOP.Utils;


namespace EntityOOP;


internal static class Program {
    public static void Main() {
        Display.Title();
        Console.Write("Press enter to start the game.");
        Console.ReadKey();
        Console.Clear();
        
        new MainMenu().Show();
    }
}