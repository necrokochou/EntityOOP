namespace EntityOOP.Utils;


public class Display {
    // FIELDS
    


    // PROPERTIES



    // CONSTRUCTOR



    // METHODS
    public static void DisplayOptions(Entity[] entities) {
        for (int i = 0; i < entities.Length; i++) {
            if (entities[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + entities[i].Name);
        }
    }

    public static void DisplayOptions(string[] actions) {
        for (int i = 0; i < actions.Length; i++) {
            if (actions[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + actions[i]);
        }
    }
}
