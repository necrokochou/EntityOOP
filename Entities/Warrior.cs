using EntityOOP.GameFramework;
using EntityOOP.Skills;
using EntityOOP.Attributes;


namespace EntityOOP.Entities;


public class Warrior : Entity {
    // FIELDS
    private GameFramework.Attribute energy;
    private Technique[] techniques;
    
    
    // PROPERTIES
    public GameFramework.Attribute Energy { get => energy; protected set => energy = value; }
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