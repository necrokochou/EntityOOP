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
        ActionPrompt = "Select technique > ";
    }
    
    
    // METHODS
    protected override string SkillName(int index) {
        return Warrior.Techniques[index].Name;
    }
    
    protected override int SkillCount() {
        return Warrior.Techniques.Length;
    }

    protected override void PerformSkill(int index, Entity target) {
        Warrior.Techniques[index].PerformSkill(target);
    }
}