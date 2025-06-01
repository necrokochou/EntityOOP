using EntityOOP.Skills.Spells;


namespace EntityOOP.Entities.Mages;


public sealed class Fern : Mage {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Fern() : base("Fern", 120f, 300f) {
        Spells = [
            new Zoltraak(this),
            new RecoveryMagic(this)
        ];
    }
    
    
    // METHODS
}
