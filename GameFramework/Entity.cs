using EntityOOP.Entities;
using EntityOOP.Skills;


namespace EntityOOP.GameFramework;


public abstract class Entity {
    // FIELDS
    private string name;
    private Attribute health;
    
    private Action action;
    
    private Entity[] entities;


    // PROPERTIES
    public string Name { get => name; protected set => name = value; }
    public Attribute Health { get => health; protected set => health = value; }
    public Action Action { get => action; protected set => action = value; }
    public Entity[] Entities { get => entities; set => entities = value; }
    

    // CONSTRUCTOR
    public Entity() { }
    
    
    // METHODS
    public void DisplayInfo() {
        Console.WriteLine(Name);
        Health.Display();
        DisplayUniqueStats();
        Console.WriteLine();
    }

    protected abstract void DisplayUniqueStats();

    public bool IsAlive() {
        return health.Current > 0;
    }
    
    public void AddSkill(Skill skill) {
        if (this is Mage mage && skill is Spell spell) {
            Spell[] spells = mage.Spells;
            Spell[] temp = new Spell[spells.Length + 1];

            for (int i = 0; i < spells.Length; i++) {
                temp[i] = spells[i];
            }
            
            temp[temp.Length - 1] = spell;
            SetSkills(temp);
        }
        
        if (this is Warrior warrior && skill is Technique technique) {
            Technique[] techniques = warrior.Techniques;
            Technique[] temp = new Technique[techniques.Length + 1];

            for (int i = 0; i < techniques.Length; i++) {
                temp[i] = techniques[i];
            }
            
            temp[temp.Length - 1] = technique;
            SetSkills(temp);
        }
    }

    protected abstract void SetSkills(Skill[] skills);
}