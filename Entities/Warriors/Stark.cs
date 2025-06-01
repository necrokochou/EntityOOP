using EntityOOP.Skills.Techniques;


namespace EntityOOP.Entities.Warriors;


public sealed class Stark : Warrior {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Stark() : base("Stark", 300f, 100f) {
        Techniques = [
            new LightningStrike(this)
        ];
    }
    
    
    // METHODS
}