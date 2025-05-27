using EntityOOP.Attributes;
using EntityOOP.Skills;


namespace EntityOOP.Entities;


public abstract class Mage : Entity {
    // FIELDS
    private Attribute mana;
    private Spell[] spells;
    
    
    // PROPERTIES
    public Attribute Mana { get => mana; protected set => mana = value; }
    public Spell[] Spells { get => spells; protected set => spells = value; }
    
    
    // CONSTRUCTOR
    public Mage(string name, float health, float mana) {
        Name = name;
        Health = new Health(health);
        Mana = new Mana(mana);
    }
    

    // METHODS
    protected override void DisplayUniqueStats() {
        Mana.Display();
    }
}