using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public sealed class Reelseiden : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Reelseiden(Mage spellOwner) : base(spellOwner) {
        Name = "Reelseiden";
        Damage = 85f;
        Cost = 75f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}