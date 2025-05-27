using EntityOOP.Attributes;
using EntityOOP.Skills;


namespace EntityOOP.Entities;


public abstract class Warrior : Entity {
    // FIELDS
    private Attribute energy;
    private Technique[] techniques;
    
    
    // PROPERTIES
    public Attribute Energy { get => energy; protected set => energy = value; }
    public Technique[] Techniques { get => techniques; protected set => techniques = value; }
    
    
    
    // CONSTRUCTOR
    public Warrior(string name, float health, float energy) {
        Name = name;
        Health = new Health(health);
        Energy = new Energy(energy);
    }

    
    // METHODS
    protected override void DisplayUniqueStats() {
        Energy.Display();
    }
}