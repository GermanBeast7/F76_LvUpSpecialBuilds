using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
    public class Character
    {
        public Character(int level, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, string name)
        {
            Level = level;
            StrengthLevel = strength;
            PerceptionLevel = perception;
            EnduranceLevel = endurance;
            CharismaLevel = charisma;
            IntelligenceLevel = intelligence;
            AgilityLevel = agility;
            LuckLevel = luck;
            Name = name;
            
        }
        public int Level { get; set; }
        public int StrengthLevel { get; set; }
        public int PerceptionLevel { get; set; }
        public int EnduranceLevel { get; set; }
        public int CharismaLevel { get; set; }
        public int IntelligenceLevel { get; set; }
        public int AgilityLevel { get; set; }
        public int LuckLevel { get; set; }
        public string Name { get; set; }

        public void defaultCharacter()
        {
            Level = 1;
            StrengthLevel = 1;
            PerceptionLevel = 1;
            EnduranceLevel = 1;
            CharismaLevel = 1;
            IntelligenceLevel = 1;
            AgilityLevel = 1;
            LuckLevel = 1;
            Name = "";

        }
        public void Save()
        {
            //Saves the stats to the database
        }
        public void Load()
        {
            //loads the stats and values to the variables from the database 
           
        }
    }
}
