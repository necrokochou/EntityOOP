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
        ActionPrompt = "Select spell > ";
    }
    
    
    // METHODS
    protected override string SkillName(int index) {
        return Mage.Spells[index].Name;
    }
    
    protected override int SkillCount() {
        return Mage.Spells.Length;
    }

    protected override void PerformSkill(int index, Entity target) {
        Mage.Spells[index].PerformSkill(target);
    }
}