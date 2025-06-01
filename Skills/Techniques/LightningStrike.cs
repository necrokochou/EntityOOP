using EntityOOP.Entities;


namespace EntityOOP.Skills.Techniques;


public sealed class LightningStrike : Technique {
    // FIELDS
    
    
    
    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public LightningStrike(Warrior techniqueOwner) : base(techniqueOwner) {
        Owner = techniqueOwner;
        Name = "Lightning Strike";
        Damage = 70f;
        Cost = 20f;
        Cooldown = 1f;
        DoesDamage = true;
    }


    // METHODS
}