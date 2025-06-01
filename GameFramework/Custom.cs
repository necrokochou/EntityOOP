using EntityOOP.Entities;
using EntityOOP.Skills.Spells;
using EntityOOP.Skills.Techniques;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public sealed class Custom {
    // FIELDS
    private string name;
    private string classType;
    private int maxSkillCount;
    
    private string[] spellsDict;
    private string[] techniquesDict;


    // PROPERTIES
   
    

    // CONSTRUCTOR
    public Custom() {
        maxSkillCount = 2;
        
        spellsDict = new string[Constants.SPELLS.Length];
        for (int i = 0; i < spellsDict.Length; i++) {
            spellsDict[i] = Constants.SPELLS[i];
        }
        techniquesDict = new string[Constants.TECHNIQUES.Length];
        for (int i = 0; i < techniquesDict.Length; i++) {
            techniquesDict[i] = Constants.TECHNIQUES[i];
        }
    }


    // METHODS
    
    public Entity Create() {
        Entity customEntity = null;
        name = Input.ReadString("name");
        
        Display.Options(Constants.CLASSES);
        int input = Input.Select(Constants.CLASSES.Length, "class", true);
        classType = Constants.CLASSES[input];
        
        switch (classType) {
            case "Mage" :
                customEntity = new Mage(name, 100f, 100f);
                AddSkills((Mage) customEntity);
                break;
            case "Warrior" :
                customEntity = new Warrior(name, 100f, 100f);
                AddSkills((Warrior) customEntity);
                break;
            case "Priest" :
                customEntity = new Priest(name, 100f);
                AddSkills((Priest) customEntity);
                break;
        }
            
        Input.PressAnyKey();
        
        Console.Write("Created " + classType + " " + customEntity.Name + ".");
        Input.PressAnyKey();
        
        return customEntity;
    }

    private void AddSkills(Entity entity, bool useMaxSkillCount = true) {
        switch (entity) {
            case Mage mage : InitializeSkills(mage, useMaxSkillCount); break;
            case Warrior warrior : InitializeSkills(warrior, useMaxSkillCount); break;
            case Priest priest : InitializeSkills(priest, useMaxSkillCount); break;
        }
    }
    
    private void InitializeSkills(Mage mage, bool useMaxSkillCount) {
        if (!useMaxSkillCount || maxSkillCount > spellsDict.Length) maxSkillCount = spellsDict.Length;
        
        for (int i = 0; i < maxSkillCount; i++) {
            Display.Options(spellsDict);
            int input = Input.Select(spellsDict.Length, "spell", true);
            
            switch (spellsDict[input]) {
                case "Zoltraak" :
                    mage.AddSkill(new Zoltraak(mage));
                    break;
                case "Reelseiden" :
                    mage.AddSkill(new Reelseiden(mage));
                    break;
                case "Recovery Magic" :
                    mage.AddSkill(new RecoveryMagic(mage));
                    break;
            }
            Console.Write("Added " + spellsDict[i] + " to " + mage.Name + "'s skills.");
            Console.ReadKey();
        }
    }

    private void InitializeSkills(Warrior warrior, bool useMaxSkillCount) {
        if (!useMaxSkillCount || maxSkillCount > spellsDict.Length) maxSkillCount = spellsDict.Length;
        
        for (int i = 0; i < maxSkillCount; i++) {
            Display.Options(techniquesDict);
            int input = Input.Select(techniquesDict.Length, "technique", true);

            switch (techniquesDict[input]) {
                case "Lightning Strike" :
                    warrior.AddSkill(new LightningStrike(warrior));
                    break;
            }
            Console.WriteLine("Added " + techniquesDict[i] + " to " + warrior.Name + "'s skills.");
        }
    }
    
    private void InitializeSkills(Priest priest, bool useMaxSkillCount) { }
}
