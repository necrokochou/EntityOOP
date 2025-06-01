using EntityOOP.GameFramework;
using EntityOOP.Attributes;


namespace EntityOOP.Entities;


public  class Priest : Entity {
    // FIELDS
    


    // PROPERTIES



    // CONSTRUCTOR
    public Priest(string name, float health) {
        Name = name;
        Health = new Health(health);
    }


    // METHODS
    protected override void DisplayUniqueStats() { }
    
    protected override void SetSkills(Skill[] skills) { }
}
