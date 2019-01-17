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
        // Only public attributes so they can be serialized by XMl Serialization
        // Main.cs uses the methods below to mutate and get values of an object of this class
        public int Level;
        public int StrengthLevel;
        public int PerceptionLevel;
        public int EnduranceLevel;
        public int CharismaLevel;
        public int IntelligenceLevel;
        public int AgilityLevel;
        public int LuckLevel;
        public string Name;
        
       //Methods to mutate or to get values of the class
       public void addLevel()
        {
            Level += 1;
        }
        public void subLevel()
        {
            Level -= 1;
        }
        public int getLevel()
        {
            return Level;
        }
        public void addStr()
        {
            StrengthLevel += 1;
        }
        public void subStr()
        {
            StrengthLevel -= 1;
        }
        public int getStr()
        {
            return StrengthLevel;
        }
        public void addPer()
        {
            PerceptionLevel += 1;
        }
        public void subPer()
        {
            PerceptionLevel -= 1;
        }
        public int getPer()
        {
            return PerceptionLevel;
        }
        public void addEnd()
        {
            EnduranceLevel += 1;
        }
        public void subEnd()
        {
            EnduranceLevel -= 1;
        }
        public int getEnd()
        {
            return EnduranceLevel;
        }
        public void addCha()
        {
            CharismaLevel += 1;
        }
        public void subCha()
        {
            CharismaLevel -= 1;
        }
        public int getCha()
        {
            return CharismaLevel;
        }
        public void addInt()
        {
            IntelligenceLevel += 1;
        }
        public void subInt()
        {
            IntelligenceLevel -= 1;
        }
        public int getInt()
        {
            return IntelligenceLevel;
        }
        public void addAgi()
        {
            AgilityLevel += 1;
        }
        public void subAgi()
        {
            AgilityLevel -= 1;
        }
        public int getAgi()
        {
            return AgilityLevel;
        }
        public void addLuc()
        {
            LuckLevel += 1;
        }
        public void subLuc()
        {
            LuckLevel -= 1;
        }
        public int getLuc()
        {
            return LuckLevel;
        }
        public void changeName(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }



    }
}
