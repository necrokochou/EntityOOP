using EntityOOP.GameFramework;
using EntityOOP.Entities;


namespace EntityOOP.Actions;


public class WarriorAction : GameFramework.Action {
    // FIELDS
    private Warrior warrior;
    
    
    // PROPERTIES
    private Warrior Warrior { get => warrior; set => warrior = value; }
    
    
    // CONSTRUCTOR
    public WarriorAction(Warrior currentEntity) : base(currentEntity) {
        Warrior = currentEntity;
        Actions = ["Use Moves"];
        ActionPrompt = "technique";
    }
    
    
    // METHODS
    protected override Skill[] Skills() {
        return Warrior.Techniques;
    }

    protected override void PerformSkill(int index, Entity target) {
        Warrior.Techniques[index].Perform(target);
    }
}