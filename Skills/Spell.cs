using EntityOOP.Entities;


namespace EntityOOP.Skills;


public abstract class Spell : Skill {
    // FIELDS
    private Mage spellOwner;


    // PROPERTIES
    public Mage SpellOwner { get => spellOwner; protected set => spellOwner = value;}
    

    // CONSTRUCTOR
    public Spell(Mage spellOwner) : base(spellOwner) {
        SpellOwner = spellOwner;
        ActionType = "cast";
    }


    // METHODS
    protected override string ApplyCost() {
        SpellOwner.Mana.Decrease(Cost);
        return "mana";
    }
}