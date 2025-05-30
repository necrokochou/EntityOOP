using EntityOOP.Actions;
using EntityOOP.Skills.Spells;


namespace EntityOOP.Entities.Mages;


public sealed class Frieren : Mage {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Frieren() : base("Frieren", 200f, 500f) {
        Action = new MageAction(this);
        Spells = [
            new Zoltraak(this)
        ];
    }
    
    
    // METHODS
}