using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Engine
{
    [Serializable]
    public class Character
    {   
        //Seperated Construct() to be able to serialize the class
        public Character()
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
        public void Construct(int level = 1, int strength = 1, int perception = 1, int endurance = 1, int charisma = 1, int intelligence = 1, int agility = 1, int luck = 1, string name = "")
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
        
       
      
        

    }
}
