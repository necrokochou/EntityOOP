using EntityOOP.GameFramework;


namespace EntityOOP.Utils;


public sealed class Input {
    // FIELDS


    // PROPERTIES



    // CONSTRUCTOR
    public Input() { }


    // METHODS
    public static void PressAnyKey() {
        Console.ReadKey();
        Console.Clear();
    }
    
    public static int Read() {
        return int.Parse(Console.ReadLine());
    }

    public static int Select(int optionsCount, string prompt, bool outOfIndex = false) {
        int input;
        
        while (true) {
            Console.Write("Select " + prompt + " > ");
            try {
                input = Read();
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }
            
            if (outOfIndex && OutOfIndex(input, optionsCount)) continue;

            break;
        }
        
        Console.WriteLine();
        return input - 1;
    }

    private static bool OutOfIndex(int input, int length) {
        if (input < 1 || input > length) {
            Console.WriteLine("Invalid input. Out of range.");
            return true;
        }

        return false;
    }
    
    public static string ReadString(string prompt) {
        while (true) {
            Console.Write("Enter " + prompt + " > ");
            string str = Console.ReadLine();

            bool valid = str != "";
            
            foreach (char c in str) {
                if (!(char.IsLetter(c) || char.IsWhiteSpace(c))) {
                    valid = false;
                    break;
                }
            }
            
            if (valid) return str;
            Console.WriteLine("Invalid input. Only letters and spaces are allowed.");
        }
    }
}
