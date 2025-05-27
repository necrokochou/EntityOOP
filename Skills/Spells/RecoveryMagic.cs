using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public class RecoveryMagic : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public RecoveryMagic(Mage spellOwner) : base(spellOwner) {
        Name = "Recovery Magic";
        Heal = 15f;
        Cost = 20f;
        Cooldown = 1f;
        DoesHealing = true;
    }


    // METHODS
}
