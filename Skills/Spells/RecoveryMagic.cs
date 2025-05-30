using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public sealed class RecoveryMagic : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public RecoveryMagic(Mage spellOwner) : base(spellOwner) {
        Name = "Recovery Magic";
        Heal = 65f;
        Cost = 70f;
        Cooldown = 1f;
        DoesHealing = true;
    }


    // METHODS
}
