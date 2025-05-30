using EntityOOP.GameFramework;
using EntityOOP.Entities;


namespace EntityOOP.Skills;


public abstract class Technique : Skill {
    // FIELDS
    private Warrior techniqueOwner;


    // PROPERTIES
    public Warrior TechniqueOwner { get => techniqueOwner; protected set => techniqueOwner = value; }


    // CONSTRUCTOR
    public Technique(Warrior techniqueOwner) : base(techniqueOwner) {
        TechniqueOwner = techniqueOwner;
        ActionString = "execute";
    }


    // METHODS
    protected override string ApplyCost() {
        TechniqueOwner.Energy.Decrease(Cost);
        return "energy";
    }
}