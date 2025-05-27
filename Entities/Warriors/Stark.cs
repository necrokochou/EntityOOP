using EntityOOP.Actions;
using EntityOOP.Skills.Techniques;


namespace EntityOOP.Entities.Warriors;


public class Stark : Warrior {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Stark() : base("Stark", 300f, 100f) {
        Action = new WarriorAction(this);
        Techniques = [new LightningStrike(this)];
    }
    
    
    // METHODS
}