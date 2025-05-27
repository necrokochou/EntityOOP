using EntityOOP.Entities;


namespace EntityOOP.Actions;


public class MageAction : Action {
    // FIELDS
    private Mage mage;
    
    
    // PROPERTIES
    private Mage Mage { get => mage; set => mage = value; }
    
    
    // CONSTRUCTOR
    public MageAction(Mage currentEntity) : base(currentEntity) {
        Mage = currentEntity;
        Actions = ["Use Spell"];
    }
    
    
    // METHODS
    protected override void PerformAction() {
        UseSpell();
    }
    
    public void UseSpell() {
        Entity target = SelectTarget();

        for (int i = 0; i < Mage.Spells.Length; i++) {
            if (Mage.Spells[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + Mage.Spells[i].Name);
        }

        while (true) {
            Console.Write("Select spell > ");
            int input;
            try {
                input = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }
            
            if (input < 1 || input > Mage.Spells.Length) {
                Console.WriteLine("Invalid input.");
                continue;
            }

            Mage.Spells[input - 1].Cast(target);
            break;
        }
    }
}