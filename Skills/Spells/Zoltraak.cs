using EntityOOP.Entities;


namespace EntityOOP.Skills.Spells;


public class Zoltraak : Spell {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Zoltraak(Mage spellOwner) {
        SpellOwner = spellOwner;
        Name = "Zoltraak";
        Damage = 10f;
        Cost = 5f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}