using EntityOOP.Entities;
using EntityOOP.Skills.Spells;
using EntityOOP.Skills.Techniques;
using EntityOOP.Utils;


namespace EntityOOP.GameFramework;


public sealed class Custom {
    // FIELDS
    private Entity customEntity;
    private string name;
    private string classType;
    private string[] skills;
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

        skills = new string[maxSkillCount];
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
                InitializeSkills((Mage) customEntity);
                break;
            case "Warrior" :
                customEntity = new Warrior(name, 100f, 100f);
                InitializeSkills((Warrior) customEntity);
                break;
            case "Priest" :
                customEntity = new Priest(name, 100f);
                InitializeSkills((Priest) customEntity);
                break;
        }
        
        return customEntity;
    }
    
    private void InitializeSkills(Mage mage) {
        AddSkills(spellsDict);
        
        for (int i = 0; i < maxSkillCount; i++) {
            switch (skills[i]) {
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
            Console.WriteLine("Added " + skills[i] + " to " + mage.Name + "'s skills.");
        }
    }

    private void InitializeSkills(Warrior warrior) {
        AddSkills(techniquesDict);
        
        for (int i = 0; i < maxSkillCount; i++) {
            switch (skills[i]) {
                case "Lightning Strike" :
                    warrior.AddSkill(new LightningStrike(warrior));
                    break;
            }
            Console.WriteLine("Added " + skills[i] + " to " + warrior.Name + "'s skills.");
        }
    }
    
    private void InitializeSkills(Priest priest) { }

    private void AddSkills(string[] skillsDict, bool useMaxSkillCount = true) {
        if (!useMaxSkillCount || maxSkillCount > skillsDict.Length) maxSkillCount = skillsDict.Length;

        for (int i = 0; i < maxSkillCount; i++) {
            Display.Options(skillsDict);
            int input = Input.Select(skillsDict.Length, "skill", true);
            skills[i] = skillsDict[input];
        }
    }
}
