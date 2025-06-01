using EntityOOP.Skills.Spells;


namespace EntityOOP.Entities.Mages;


public sealed class Frieren : Mage {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Frieren() : base("Frieren", 200f, 500f) {
        Spells = [
            new Zoltraak(this)
        ];
    }
    
    
    // METHODS
}