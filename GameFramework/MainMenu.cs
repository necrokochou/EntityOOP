using EntityOOP.Entities.Mages;
using EntityOOP.Entities.Warriors;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public class MainMenu {
    // FIELDS
    Custom custom = new Custom();
    private static string[] mainOptions = ["Play", "Pre-made characters", "Create custom character", "Exit"];
    private string[] preMadeOptions = ["Add character", "Remove character", "Back"];
    private Entity[] initialEntities = [];

    private string[] characters;
    private bool[] added;


    // PROPERTIES
    private string[] Characters { get => characters; }


    // CONSTRUCTOR
    public MainMenu() {
        characters = Constants.ENTITIES;
    }


    // METHODS
    public void Show() {
        while (true) {
            Display.Options(mainOptions);
            int input = Input.Select(mainOptions.Length, "option");

            switch (input + 1) {
                case 1 :
                    // game.AddedCharacters = selected;
                    InitializeCustom();
                    Debug.Show(initialEntities);
                    Console.ReadKey();
                    Core game = new Core();
                    game.Run();
                    break;
                case 2 :
                    PreMadeCharacters();
                    break;
                case 3 :
                    custom.Create();
                    break;
                case 4 :
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default :
                    Console.WriteLine("Invalid input. Try again.");
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
                    Console.WriteLine("Invalid input. Try again.");
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
        while (true) {
            Display.Options(characters);
            int input = Input.Select(characters.Length, "character", true);
            
            Initialize(CharDict(characters[input]));
            ReloadCharDict(characters[input]);

            break;
        }
    }

    private void ReloadCharDict(string name) {
        for (int i = 0; i < characters.Length; i++) {
            if (characters[i] != null && characters[i] == name)
                characters[i] = null;
        }
        
        string[] reloadedCharDict = new string[characters.Length];
        int index = 0;
        for (int i = 0; i < reloadedCharDict.Length; i++) {
            if (characters[i] == null) continue;
            
            reloadedCharDict[index] = characters[i];
            index++;
        }
        
        characters = reloadedCharDict;
    }

    private void Initialize(Entity entity) {
        Entity[] temp = initialEntities;
        int count = initialEntities.Length;
        
        initialEntities = new Entity[count + 1];
        for (int i = 0; i < initialEntities.Length && i < temp.Length; i++) {
            initialEntities[i] = temp[i];
        }
        
        initialEntities[count] = entity;
    }

    private void InitializeCustom() {
        Entity[] tempInitial = initialEntities;
        Entity[] tempCustom = custom.CustomEntities;
        
        int count = initialEntities.Length + custom.CustomEntities.Length;
        if (tempInitial.Length + tempCustom.Length != count) return;
        
        initialEntities = new Entity[count];
        for (int i = 0; i < tempInitial.Length; i++) {
            initialEntities[i] = tempInitial[i];
        }
        for (int i = 0; i < tempCustom.Length; i++) {
            initialEntities[i + tempInitial.Length] = tempCustom[i];
        }
    }
    
    private void RemoveCharacter() { }

    // private void AddCharacter() {
    //     ModifySelected(true);
    // }
    //
    // private void RemoveCharacter() {
    //     ModifySelected(false);
    // }
    //
    // private void ModifySelected(bool add) {
    //     while (true) {
    //         int input = Input.Select(4, "character");
    //
    //         Constants.Characters character;
    //         string name;
    //
    //         switch (input + 1) {
    //             case 1:
    //                 character = Constants.Characters.Frieren;
    //                 name = "Frieren";
    //                 break;
    //             case 2:
    //                 character = Constants.Characters.Fern;
    //                 name = "Fern";
    //                 break;
    //             case 3:
    //                 character = Constants.Characters.Ubel;
    //                 name = "Ubel";
    //                 break;
    //             case 4:
    //                 character = Constants.Characters.Stark;
    //                 name = "Stark";
    //                 break;
    //             default:
    //                 continue;
    //         }
    //
    //         if (add) {
    //             selected |= character;
    //             Console.WriteLine($"Added {name}.");
    //         } else {
    //             selected &= ~character;
    //             Console.WriteLine($"Removed {name}.");
    //         }
    //
    //         break;
    //     }
    // }
    //
    // public void AddCharacters() {
    //     while (true) {
    //         int input = Input.Select(addOptions.Length, "option");
    //         
    //         switch (input + 1) {
    //             case 1 :
    //                 AddCharacter();
    //                 break;
    //             case 2 :
    //                 RemoveCharacter();
    //                 break;
    //             default:
    //                 continue;
    //         }
    //     }
    // }
}
