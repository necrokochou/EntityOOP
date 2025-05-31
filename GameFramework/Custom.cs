using EntityOOP.Entities;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public sealed class Custom {
    // FIELDS
    private string[] classes = ["Mage", "Warrior", "Priest"];
    
    private Entity customEntity;
    private string classType;
    private string name;
    
    private Entity[] customEntities = [];


    // PROPERTIES
    public Entity[] CustomEntities { get => customEntities; private set => customEntities = value; }
    

    // CONSTRUCTOR
    public Custom() { }


    // METHODS
    
    public void Create() {
        Define();
        
        while (true) {
            switch (classType) {
                case "Mage" :
                    customEntity = new Mage(name, 100f, 100f);
                    break;
                case "Warrior" :
                    customEntity = new Warrior(name, 100f, 100f);
                    break;
                case "Priest" :
                    customEntity = new Priest(name, 100f);
                    break;
                default :
                    Console.WriteLine("Invalid class type. Try again.");
                    continue;
            }

            break;
        }
        
        AddCustomEntity(customEntity);
    }
    
    private void Define() {
        // Class Type
        Display.Options(classes);
        int input = Input.Select(classes.Length, "class", true);
        classType = classes[input];
        
        // Entity Name
        name = Input.ReadString("name");
        Console.WriteLine();
    }

    private void AddCustomEntity(Entity custom) {
        Entity[] temp = CustomEntities;
        int count = CustomEntities.Length;
        
        CustomEntities = new Entity[count + 1];
        for (int i = 0; i < temp.Length; i++) {
            CustomEntities[i] = temp[i];
        }
        CustomEntities[count] = custom;
    }
}
