using EntityOOP.Entities.Mages;
using EntityOOP.Entities.Warriors;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public sealed class Core {
    // FIELDS
    private Entity[] entities;
    private Entity[] sortedEntities;
    private Entity currentEntity;

    // private Constants.Characters addedCharacters;
    

    // PROPERTIES
    // public Constants.Characters AddedCharacters { get => addedCharacters; set => addedCharacters = value; }
    // public int Turn { get => turn; private set => turn = value; }
    // public int CurrentTurn { get => currentTurn; private set => currentTurn = value; }
    // public Entity[] Entities { get => entities; private set => entities = value; }
    // public Entity CurrentEntity { get => currentEntity; private set => currentEntity = value; }
    
    
    // CONSTRUCTOR
    public Core() { }


    // METHODS
    public void Run() {
        InitializeEntities();
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
                Console.WriteLine(sortedEntities[0].Name + " has won this battle.");
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
    
    private void InitializeEntities(int entityCount = 4) {
        entities = new Entity[entityCount];

        entities[0] = new Frieren();
        entities[1] = new Fern();
        entities[2] = new Ubel();
        entities[3] = new Stark();

        AssignEntitiesToAll();
    }

    public void AssignEntitiesToAll() {
        foreach (Entity entity in entities) {
            if (entity != null) entity.Entities = entities;
        }
    }

    private void RemoveDeadEntities() {
        for (int i = 0; i < entities.Length; i++) {
            if (entities[i] != null && !entities[i].IsAlive()) entities[i] = null;
        }
    }

    private void ReloadEntities() {
        RemoveDeadEntities();
        
        Entity[] reloadedEntities = new Entity[entities.Length];
        int index = 0;
        for (int i = 0; i < reloadedEntities.Length; i++) {
            if (entities[i] == null) continue;
            
            reloadedEntities[index] = entities[i];
            index++;
        }
        sortedEntities = reloadedEntities;

        foreach (Entity entity in entities) {
            if (entity != null) entity.Entities = sortedEntities;
        }
    }

    private int GetAliveCount() {
        int count = 0;
        
        foreach (Entity entity in entities) {
            if (entity != null && entity.IsAlive()) count++;
        }

        return count;
    }
}
