using EntityOOP.Entities;


namespace EntityOOP.Skills.Techniques;


public class LightningStrike : Technique {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public LightningStrike(Warrior techniqueOwner) : base(techniqueOwner) {
        Owner = techniqueOwner;
        Name = "Lightning Strike";
        Damage = 30f;
        Cost = 10f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}