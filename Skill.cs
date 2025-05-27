namespace EntityOOP;


public abstract class Skill {
    // FIELDS
    private string name;
    private float damage;
    private float heal;
    private float cost;
    private float cooldown;
    //private Entity owner;
    private Entity target;
    
    private bool doesDamage;
    private bool doesHealing;


    // PROPERTIES
    // public Entity User { get => user; protected set => user = value; }
    //public Entity Owner { get => owner; protected set => owner = value; }
    public Entity Target { get => target; protected set => target = value; }
    public string Name { get => name; protected set => name = value; }
    public float Damage { get => damage; protected set => damage = value; }
    public float Heal { get => heal; protected set => heal = value; }
    public float Cost { get => cost; protected set => cost = value; }
    public float Cooldown { get => cooldown; protected set => cooldown = value; }
    protected bool DoesDamage { get => doesDamage; set => doesDamage = value; }
    protected bool DoesHealing { get => doesHealing; set => doesHealing = value; }
    

    // CONSTRUCTOR
    public Skill() { }


    // METHODS
    protected abstract void PerformSkill();

    protected void SpellType() {
        if (DoesDamage) DoDamage();
        if (doesHealing) DoHeal();
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