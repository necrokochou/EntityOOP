using EntityOOP.GameFramework;


namespace EntityOOP.Utils;


public sealed class Debug {
    // FIELDS



    // PROPERTIES



    // CONSTRUCTOR
    public Debug() { }


    // METHODS
    public static void Show(int intVal) {
        Console.WriteLine("##########DEBUG########## => " + intVal);
    }

    public static void Show(bool boolVal) {
        Console.WriteLine("##########DEBUG########## => " + boolVal);
    }

    public static void Show(string strVal) {
        Console.WriteLine("##########DEBUG########## => " + strVal + "\n");
    }


    public static void Show(string[] strArr) {
        int index = 0;

        if (strArr.Length == 0) return;
        Console.WriteLine("##########DEBUG##########");
        foreach (string str in strArr) {
            if (str is null) {
                Console.WriteLine("null");
                continue;
            }
            Console.WriteLine(index + 1 + " -> " + str);
            index++;
        }
        Console.WriteLine("##########DEBUG##########\n");
    }
    
    public static void Show(Entity[] entities, bool fullInfo = false) {
        int index = 0;

        if (entities.Length == 0) return;
        Console.WriteLine("##########DEBUG##########");
        foreach (Entity entity in entities) {
            if (entity is null) {
                Console.WriteLine("null");
                continue;
            }

            if (fullInfo) entity.DisplayInfo();
            else {
                Console.WriteLine(index + 1 + " -> " + entity.Name);
            }

            index++;
        }
        Console.WriteLine("##########DEBUG##########\n");
    }

    public static void Show(Skill[] skills) {
        if (skills.Length == 0) return;
        Console.WriteLine("##########DEBUG##########");
        foreach (Skill skill in skills) {
            if (skill is null) {
                Console.WriteLine("null");
            }
        }
        Console.WriteLine("##########DEBUG##########\n");
    }
}
