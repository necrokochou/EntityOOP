using EntityOOP.Entities;


namespace EntityOOP.Actions;


public class WarriorAction : Action {
    // FIELDS
    private Warrior warrior;
    
    
    // PROPERTIES
    private Warrior Warrior { get => warrior; set => warrior = value; }
    
    
    // CONSTRUCTOR
    public WarriorAction(Warrior currentEntity) : base(currentEntity) {
        Warrior = currentEntity;
        Actions = ["Use Moves"];
    }
    
    
    // METHODS
    protected override void PerformAction() {
        UseMove();
    }
    
    public void UseMove() {
        Entity target = SelectTarget();

        for (int i = 0; i < Warrior.Techniques.Length; i++) {
            if (Warrior.Techniques[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + Warrior.Techniques[i].Name);
        }

        while (true) {
            Console.Write("Select move > ");
            int input;
            try {
                input = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }
            
            if (input < 1 || input > Warrior.Techniques.Length) {
                Console.WriteLine("Invalid input.");
                continue;
            }

            Warrior.Techniques[input - 1].Execute(target);
            break;
        }
    }
}