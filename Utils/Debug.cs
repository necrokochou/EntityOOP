using EntityOOP.GameFramework;


namespace EntityOOP.Utils;


public sealed class Debug {
    // FIELDS

    

    // PROPERTIES



    // CONSTRUCTOR
    public Debug() { }


    // METHODS
    public static void Show(int integer) {
        Console.WriteLine("##########DEBUG########## => " + integer);
    }

    public static void Show(bool boolean) {
        Console.WriteLine("##########DEBUG########## => " + boolean);
    }
    
    public static void Show(Entity[] entities, bool fullInfo = false) {
        int index = 0;

        if (entities.Length == 0) return;
        foreach (Entity entity in entities) {
            if (index == 0)
                Console.WriteLine("##########DEBUG##########");
            
            if (entity is null) {
                Console.WriteLine("null");
                continue;
            }
            if (fullInfo) entity.DisplayInfo();
            else {
                Console.WriteLine(index + 1 + " -> " + entity.Name);
            }
            index++;
            
            if (index == entities.Length)
                Console.WriteLine("##########DEBUG##########");
        }
    }
}
