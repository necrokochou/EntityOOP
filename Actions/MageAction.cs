using EntityOOP.GameFramework;
using EntityOOP.Entities;


namespace EntityOOP.Actions;


public class MageAction : GameFramework.Action {
    // FIELDS
    private Mage mage;
    
    
    // PROPERTIES
    private Mage Mage { get => mage; set => mage = value; }
    
    
    // CONSTRUCTOR
    public MageAction(Mage currentEntity) : base(currentEntity) {
        Mage = currentEntity;
        Actions = ["Use Spell"];
        ActionPrompt = "spell";
    }
    
    
    // METHODS
    protected override Skill[] Skills() {
        return Mage.Spells;
    }

    protected override void PerformSkill(int index, Entity target) {
        Mage.Spells[index].Perform(target);
    }
}