using EntityOOP.GameFramework;


namespace EntityOOP.Utils;


public sealed class Display {
    // FIELDS
    


    // PROPERTIES



    // CONSTRUCTOR
    public Display() { }


    // METHODS
    public static void Options(string[] strings) {
        for (int i = 0; i < strings.Length; i++) {
            if (strings[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + strings[i]);
        }
    }
    
    public static void Options(Entity[] entities) {
        for (int i = 0; i < entities.Length; i++) {
            if (entities[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + entities[i].Name);
        }
    }

    public static void Options(Skill[] skills) {
        for (int i = 0; i < skills.Length; i++) {
            if (skills[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + skills[i].Name);
        }
    }
    
    public static void Title() {
        Console.WriteLine("Console text-based and turn-based game made by necrokochou");
        Console.WriteLine("Inspired from the anime/manga Frieren: Beyond Journey's End");
        Console.WriteLine("https://github.com/necrokochou");
        Console.WriteLine();
    }
}
