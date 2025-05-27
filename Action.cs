namespace EntityOOP;


public abstract class Action {
    // FIELDS
    private Entity[] entities;
    private Entity currentEntity;
    private string[] actions;

    
    // PROPERTIES
    public Entity[] Entities { get => entities; protected set => entities = value; }
    public Entity CurrentEntity { get => currentEntity; protected set => currentEntity = value; }
    public string[] Actions { get => actions; protected set => actions = value; }
    
    
    // CONSTRUCTOR
    public Action(Entity currentEntity) {
        CurrentEntity = currentEntity;
    }
    

    // METHODS
    public void Turn() {
        for (int i = 0; i < Actions.Length; i++) {
            Console.WriteLine(i + 1 + " -> " + Actions[i]);
        }

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

    protected abstract void PerformAction();

    public Entity SelectTarget() {
        Entities = CurrentEntity.Entities;
        
        for (int i = 0; i < Entities.Length; i++) {
            if (Entities[i] is null) continue;
            Console.WriteLine(i + 1 + " -> " + Entities[i].Name);
        }

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