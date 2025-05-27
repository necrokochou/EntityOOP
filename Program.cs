using EntityOOP.Entities.Mages;
using EntityOOP.Entities.Warriors;


namespace EntityOOP;


internal static class Program {
    public static void Main() {
        //Console.WriteLine("Main");
        
        Entity[] entities = InitializeEntities();
        

        int turn = 0;
        while (true) {
            int currentTurn = turn % entities.Length;
            if (entities[currentTurn] is null) continue;
                
            Console.WriteLine(entities[currentTurn].Name + "'s turn");
            entities[currentTurn].DisplayInfo();
            entities[currentTurn].Action.Turn();
            Console.ReadKey();
            Console.Clear();
            turn++;
        }
    }

    private static Entity[] InitializeEntities(int entityCount = 4) {
        Entity[] entities = new Entity[entityCount];

        entities[0] = new Frieren();
        entities[1] = new Fern();
        entities[2] = new Ubel();
        entities[3] = new Stark();

        AssignEntitiesToAll(entities);

        return entities;
    }

    public static void AssignEntitiesToAll(Entity[] entities) {
        foreach (Entity entity in entities) {
            if (entity != null) entity.Entities = entities;
        }
    }

}