using EntityOOP.Actions;
using EntityOOP.Skills.Spells;


namespace EntityOOP.Entities.Mages;


public class Fern : Mage {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Fern() : base("Fern", 120f, 300f) {
        Action = new MageAction(this);
        Spells = [new Zoltraak(this)];
    }
    
    
    // METHODS
}
