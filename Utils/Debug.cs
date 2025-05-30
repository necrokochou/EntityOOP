using EntityOOP.GameFramework;


namespace EntityOOP.Utils;


public sealed class Debug {
    // FIELDS

    

    // PROPERTIES



    // CONSTRUCTOR
    public Debug() { }


    // METHODS
    public static void Show(Entity[] entities, bool fullInfo = false) {
        int index = 1;
        
        Console.WriteLine("##########DEBUG##########");
        foreach (Entity entity in entities) {
            if (entity is null) {
                Console.WriteLine("null");
                continue;
            }
            if (fullInfo) entity.DisplayInfo();
            else {
                Console.WriteLine(index + " -> " + entity.Name);
            }
            index++;
        }
        Console.WriteLine("##########DEBUG##########");
    }
}
