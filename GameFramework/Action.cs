using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public abstract class Action {
    // FIELDS
    private Entity[] entities;
    private Entity currentEntity;
    private string[] actions;
    
    private string actionPrompt;

    
    // PROPERTIES
    public Entity[] Entities { get => entities; protected set => entities = value; }
    public Entity CurrentEntity { get => currentEntity; protected set => currentEntity = value; }
    public string[] Actions { get => actions; protected set => actions = value; }
    protected string ActionPrompt { get => actionPrompt; set => actionPrompt = value; }
    
    
    // CONSTRUCTOR
    public Action(Entity currentEntity) {
        CurrentEntity = currentEntity;
    }
    

    // METHODS
    public void Turn() {
        Display.Options(Actions);

        while (true) {
            int input = Input.Select(Actions.Length, "action");

            switch (input + 1) {
                case 1 :
                    PerformAction();
                    break;
                default :
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
            }

            break;
        }
    }

    protected void PerformAction() {
        Entity target = SelectTarget();
        
        Display.Options(Skills());

        int input = Input.Select(Skills().Length, ActionPrompt, true);
        
        PerformSkill(input, target);
    }

    protected abstract Skill[] Skills();
    
    protected abstract void PerformSkill(int index, Entity target);

    public Entity SelectTarget() {
        Entities = CurrentEntity.Entities;
        
        Display.Options(Entities);

        int input;
        while (true) {
            input = Input.Select(Entities.Length, "target", true);

            if (Entities[input] == CurrentEntity) {
                Console.WriteLine("Cannot target yourself.\n");
                continue;
            }

            break;
        }
        
        return Entities[input];
    }
}