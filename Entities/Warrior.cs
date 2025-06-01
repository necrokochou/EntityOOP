using EntityOOP.Actions;
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
        Action = new WarriorAction(this);
        Techniques = [];
    }

    
    // METHODS
    protected override void DisplayUniqueStats() {
        Energy.Display();
    }

    protected override void SetSkills(Skill[] skills) {
        Techniques = (Technique[]) skills;
    }
}