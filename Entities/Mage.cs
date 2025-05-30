using EntityOOP.GameFramework;
using EntityOOP.Skills;
using EntityOOP.Attributes;


namespace EntityOOP.Entities;


public class Mage : Entity {
    // FIELDS
    private GameFramework.Attribute mana;
    private Spell[] spells;
    
    
    // PROPERTIES
    public GameFramework.Attribute Mana { get => mana; protected set => mana = value; }
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