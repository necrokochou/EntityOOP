using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public class MainMenu {
    // FIELDS
    Core game = new Core();
    Custom custom = new Custom();
    private static string[] mainOptions = ["Play", "Add pre-made characters", "Create custom character", "Exit"];
    private string[] addOptions = ["Add character", "Remove character", "Exit"];
    private Entity[] initialEntities = new Entity[4];
    // private Constants.Characters selected;


    // PROPERTIES



    // CONSTRUCTOR



    // METHODS
    public void Show() {
        while (true) {
            Display.Options(mainOptions);
            int input = Input.Select(mainOptions.Length, "option");

            switch (input + 1) {
                case 1 :
                    // game.AddedCharacters = selected;
                    game.Run();
                    break;
                case 2 :
                    AddCharacters();
                    break;
                case 3 :
                    Create();
                    break;
                case 4 :
                    Environment.Exit(0);
                    break;
                default :
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
            }
        }
    }

    private void Create() {
        custom.Create();
    }

    private void AddCharacters() {
        while (true) {
            int input = Input.Select(addOptions.Length, "option");
            
            switch (input + 1) {
                case 1 :
                    AddCharacter();
                    break;
                case 2 :
                    RemoveCharacter();
                    break;
                default:
                    continue;
            }
        }
    }

    private void AddCharacter() { }
    
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
