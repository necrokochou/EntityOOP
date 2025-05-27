using EntityOOP.Entities;


namespace EntityOOP.Skills;


public abstract class Technique : Skill {
    // FIELDS
    private Warrior techniqueOwner;


    // PROPERTIES
    public Warrior TechniqueOwner { get => techniqueOwner; protected set => techniqueOwner = value; }


    // CONSTRUCTOR
    public Technique() { }


    // METHODS
    protected override void PerformSkill() {
        Execute(Target);
    }
    
    public void Execute(Entity target) {
        Target = target;
        
        Console.WriteLine(TechniqueOwner.Name + " uses " + Name + " technique on " + Target.Name + ".");
        TechniqueOwner.Energy.Decrease(Cost);
        Console.WriteLine(TechniqueOwner.Name + " used " + Cost + " mana.");
        SpellType();
        
        // Console.WriteLine(SpellTarget.Name);
        Target.Health.Display();
    }
}