using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public sealed class Zoltraak : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Zoltraak(Mage spellOwner) : base(spellOwner) {
        Name = "Zoltraak";
        Damage = 70f;
        Cost = 50f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}