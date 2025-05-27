using EntityOOP.Utils;


namespace EntityOOP;


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
        Display.DisplayOptions(Actions);

        while (true) {
            Console.Write("Choose action > ");
            int input;
            try {
                input = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }

            switch (input) {
                // case 1 :
                //     TryDamage();
                //     break;
                case 1 :
                    PerformAction();
                    break;
                default :
                    Console.WriteLine("Invalid input.");
                    continue;
            }

            break;
        }
    }

    protected void PerformAction() {
        Entity target = SelectTarget();
        
        for (int i = 0; i < SkillCount(); i++) {
            Console.WriteLine(i + 1 + " -> " + SkillName(i));
        }

        while (true) {
            Console.Write(ActionPrompt);
            int input;
            try {
                input = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }
            
            if (input < 1 || input > SkillCount()) {
                Console.WriteLine("Invalid input.");
                continue;
            }
            
            PerformSkill(input - 1, target);
            break;
        }
    }

    protected abstract int SkillCount();
    
    protected abstract string SkillName(int index);
    
    protected abstract void PerformSkill(int index, Entity target);

    public Entity SelectTarget() {
        Entities = CurrentEntity.Entities;
        
        Display.DisplayOptions(Entities);

        while (true) {
            Console.Write("Select target > ");
            int input;
            try {
                input = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Invalid input. " + e.Message);
                continue;
            }

            if (input < 1 || input > Entities.Length) {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (Entities[input - 1] == CurrentEntity) {
                Console.WriteLine("Cannot target yourself.");
                continue;
            }
            
            return Entities[input - 1];
        }
    }
}