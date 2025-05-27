using EntityOOP.Actions;
using EntityOOP.Skills.Spells;


namespace EntityOOP.Entities.Mages;


public class Ubel : Mage {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Ubel() : base("Ubel", 150f, 120f) {
        Action = new MageAction(this);
        Spells = [new Reelseiden(this)];
    }
    
    
    // METHODS
}