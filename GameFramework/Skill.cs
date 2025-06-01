using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public abstract class Skill {
    // FIELDS
    private string name;
    private float damage;
    private float heal;
    private float cost;
    private float cooldown;
    private Entity owner;
    private Entity target;
    
    private bool doesDamage;
    private bool doesHealing;

    private string actionString;
    //private string costType;


    // PROPERTIES
    // public Entity User { get => user; protected set => user = value; }
    public Entity Owner { get => owner; protected set => owner = value; }
    public Entity Target { get => target; protected set => target = value; }
    public string Name { get => name; protected set => name = value; }
    public float Damage { get => damage; protected set => damage = value; }
    public float Heal { get => heal; protected set => heal = value; }
    public float Cost { get => cost; protected set => cost = value; }
    public float Cooldown { get => cooldown; protected set => cooldown = value; }
    protected bool DoesDamage { get => doesDamage; set => doesDamage = value; }
    protected bool DoesHealing { get => doesHealing; set => doesHealing = value; }
    protected string ActionString { get => actionString; set => actionString = value; }
    //protected string CostType { get => costType; set => costType = value; }
    

    // CONSTRUCTOR
    public Skill(Entity owner) {
        Owner = owner;
    }


    // METHODS
    public void Perform(Entity target) {
        Target = target;

        string pastTense;
        switch (ActionString[^1]) {
            case 'a' :
            case 'e' :
            case 'i' :
            case 'o' :
            case 'u' :
                pastTense = "d ";
                break;
            default:
                pastTense = "ed ";
                break;
        }
        
        string skillType = GetType().BaseType.Name.ToLower();
        string skillAction = Owner.Name + " " + ActionString + pastTense + Name + " " + skillType;
        Console.Write(skillAction + " on " + Target.Name + ".");
        string costType = ApplyCost();
        Console.Write(Owner.Name + " used " + Cost + " " + costType + ".");
        SkillType();
        
        Target.Health.Display();
            
        Input.PressAnyKey();
    }

    protected abstract string ApplyCost();

    protected void SkillType() {
        if (DoesDamage) DoDamage();
        if (doesHealing) DoHeal();
            
        Input.PressAnyKey();
    }

    protected void DoDamage() {
        Target.Health.Decrease(Damage);
        Console.WriteLine(Target.Name + " lost " + Damage + " health.");
    }

    protected void DoHeal() {
        Target.Health.Increase(Heal);
        Console.WriteLine(Target.Name + " gained " + Heal + " health.");
    }
}