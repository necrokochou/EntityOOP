using EntityOOP.Entities;


namespace EntityOOP.Skills;


public abstract class Spell : Skill {
    // FIELDS
    private Mage spellOwner;


    // PROPERTIES
    public Mage SpellOwner { get => spellOwner; protected set => spellOwner = value;}
    

    // CONSTRUCTOR
    public Spell() { }


    // METHODS
    protected override void PerformSkill() {
        Cast(Target);
    }
    
    public void Cast(Entity target) {
        Target = target;
        
        Console.WriteLine(SpellOwner.Name + " casts " + Name + " spell on " + Target.Name + ".");
        SpellOwner.Mana.Decrease(Cost);
        Console.WriteLine(SpellOwner.Name + " used " + Cost + " mana.");
        SpellType();
        
        // Console.WriteLine(SpellTarget.Name);
        Target.Health.Display();
    }
}