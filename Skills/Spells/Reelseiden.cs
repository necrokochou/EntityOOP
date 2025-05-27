using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public class Reelseiden : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Reelseiden(Mage spellOwner) : base(spellOwner) {
        Name = "Reelseiden";
        Damage = 30f;
        Cost = 10f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}