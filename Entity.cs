namespace EntityOOP;


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
        Health.Display();
        DisplayUniqueStats();
    }

    protected abstract void DisplayUniqueStats();

    public bool IsAlive() {
        return health.Current > 0;
    }
}