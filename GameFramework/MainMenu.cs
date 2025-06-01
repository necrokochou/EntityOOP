using EntityOOP.Entities.Mages;
using EntityOOP.Entities.Warriors;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public class MainMenu {
    // FIELDS
    Core game = new Core();
    Custom custom = new Custom();
    private static string[] mainOptions = ["Play", "Pre-made characters", "Create custom character", "Exit"];
    private string[] preMadeOptions = ["Add character", "Remove character", "Back"];
    
    private Entity[] initialEntities = [];
    private string[] characters;
    private string[] charDict;


    // PROPERTIES
    


    // CONSTRUCTOR
    public MainMenu() {
        characters = new string[Constants.ENTITIES.Length];
        charDict = new string[Constants.ENTITIES.Length];
        for (int i = 0; i < Constants.ENTITIES.Length; i++) {
            characters[i] = Constants.ENTITIES[i];
            charDict[i] = Constants.ENTITIES[i];
        }
    }


    // METHODS
    public void Show() {
        while (true) {
            Display.Options(mainOptions);
            int input = Input.Select(mainOptions.Length, "option");

            switch (input + 1) {
                case 1 :
                    //InitializeAll();
                    // Debug.Show(initialEntities);
                    // Console.ReadKey();
                    game.Initialize(initialEntities);
                    game.Run();
                    break;
                case 2 :
                    PreMadeCharacters();
                    break;
                case 3 :
                    Initialize(custom.Create());
                    break;
                case 4 :
                    Console.Write("Exiting...");
            
                    Input.PressAnyKey();
                    Environment.Exit(0);
                    break;
                default :
                    Console.Write("Invalid input. Try again.");
            
                    Input.PressAnyKey();
                    continue;
            }
        }
    }

    private void PreMadeCharacters() {
        while (true) {
            Display.Options(preMadeOptions);
            int input = Input.Select(preMadeOptions.Length, "option");
            
            switch (input + 1) {
                case 1 :
                    AddCharacter();
                    break;
                case 2 :
                    RemoveCharacter();
                    break;
                case 3 :
                    return;
                default:
                    Console.Write("Invalid input. Try again.");
            
                    Input.PressAnyKey();
                    continue;
            }
        }
    }

    private Entity CharDict(string input) {
        switch (input) {
            case "Frieren" : return new Frieren();
            case "Fern" : return new Fern();
            case "Ubel" : return new Ubel();
            case "Stark" : return new Stark();
            
            default : return null;
        }
    }

    private void AddCharacter() {
        if (charDict.Length == 0) {
            Console.Write("No characters available to add.");
            return;
        }
        
        Display.Options(charDict);
        int input = Input.Select(charDict.Length, "character", true);
        
        Console.Write("Added " + charDict[input] + " to the list.");
        Initialize(CharDict(charDict[input]));
        RemoveFromCharDict(charDict[input]);
        
        Input.PressAnyKey();
    }

    private void RemoveCharacter() {
        if (initialEntities.Length == 0) {
            Console.Write("No characters available to remove.");
            return;
        }
        
        Display.Options(initialEntities);
        int input = Input.Select(initialEntities.Length, "character", true);
        
        Entity[] temp = new Entity[initialEntities.Length - 1];
        int index = 0;
        for (int i = 0; i < initialEntities.Length; i++) {
            if (i == input) continue;
            
            temp[index] = initialEntities[i];
            index++;
        }
        
        Console.WriteLine("Removed " + initialEntities[input].Name + " from the list.");
        AddToCharDict(initialEntities[input].Name);
        initialEntities = temp;
        
        Input.PressAnyKey();
    }

    private void AddToCharDict(string name) {
        string[] temp = new string[charDict.Length + 1];
        int index = 0;
    
        for (int i = 0; i < charDict.Length; i++) {
            temp[index] = charDict[i];
            index++;
        }
    
        int insertPos = 0;
        int newPos = -1;
        for (int i = 0; i < characters.Length; i++) {
            if (characters[i] == name) {
                newPos = i;
                break;
            }
        }
    
        for (int i = 0; i < index; i++) {
            int currentPos = -1;
            for (int j = 0; j < characters.Length; j++) {
                if (characters[j] == temp[i]) {
                    currentPos = j;
                    break;
                }
            }
            if (currentPos > newPos) {
                insertPos = i;
                break;
            }
            insertPos = i + 1;
        }
    
        for (int i = index; i > insertPos; i--) {
            temp[i] = temp[i - 1];
        }
    
        temp[insertPos] = name;
    
        string[] newCharDict = new string[index + 1];
        for (int i = 0; i < newCharDict.Length; i++) {
            newCharDict[i] = temp[i];
        }
    
        charDict = newCharDict;
    }
    
    private void RemoveFromCharDict(string name) {
        int count = 0;
        for (int i = 0; i < charDict.Length; i++) {
            if (charDict[i] != name) count++;
        }
    
        if (count == 0) {
            charDict = [];
            return;
        }
    
        string[] temp = new string[count];
        int index = 0;
        for (int i = 0; i < charDict.Length; i++) {
            if (charDict[i] == name) continue;
            temp[index] = charDict[i];
            index++;
        }
    
        charDict = temp;
    }
    
    private void Initialize(Entity entity) {
        Entity[] temp = new Entity[initialEntities.Length + 1];
        for (int i = 0; i < initialEntities.Length; i++) {
            temp[i] = initialEntities[i];
        }
        temp[initialEntities.Length] = entity;
        initialEntities = temp;
    }
}