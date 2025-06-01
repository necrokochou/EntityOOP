using EntityOOP.Entities.Mages;
using EntityOOP.Entities.Warriors;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public sealed class Core {
    // FIELDS
    private Entity[] entities;
    private Entity[] sortedEntities;
    private Entity currentEntity;
    

    // PROPERTIES
    
    
    
    // CONSTRUCTOR
    public Core() { }


    // METHODS
    public void Run() {
        Loop();
    }
    
    private void Loop() {
        int turn = 0;
        int loopCount = 0;
        int currentTurn;
        sortedEntities = entities;
        
        while (true) {
            ReloadEntities();

            if (GetAliveCount() <= 1) {
                Console.WriteLine(sortedEntities[0].Name + " has won this battle.\n");
                break;
            }
            Console.Clear();
            
            currentTurn = turn % entities.Length;
            currentEntity = entities[currentTurn];

            if (currentEntity is null) {
                turn++;
                continue;
            }
            Console.WriteLine("Turn : " + (loopCount + 1) + "\n");
            currentEntity.DisplayInfo();
            currentEntity.Action.Turn();
            
            Console.ReadKey();

            turn++;
            loopCount++;
        }
    }

    public void Initialize(Entity[] initialEntities) {
        entities = new Entity[initialEntities.Length];
        entities = initialEntities;
        
        AssignEntitiesToAll(entities);
    }

    public void AssignEntitiesToAll(Entity[] assignedEntities) {
        foreach (Entity entity in entities) {
            if (entity != null) entity.Entities = assignedEntities;
        }
    }

    private void ReloadEntities() {
        Entity[] tempEntities = entities;
        Entity[] reloadedEntities = new Entity[tempEntities.Length];
        
        for (int i = 0; i < tempEntities.Length; i++) {
            if (tempEntities[i] != null && !tempEntities[i].IsAlive())
                tempEntities[i] = null;
        }
        
        int index = 0;
        for (int i = 0; i < tempEntities.Length; i++) {
            if (tempEntities[i] == null) continue;
            
            reloadedEntities[index] = tempEntities[i];
            index++;
        }
        
        sortedEntities = reloadedEntities;
        AssignEntitiesToAll(sortedEntities);
    }

    private int GetAliveCount() {
        int count = 0;
        
        foreach (Entity entity in entities) {
            if (entity != null && entity.IsAlive()) count++;
        }

        return count;
    }
}
