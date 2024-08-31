using System;

namespace Flyweight
{
	internal class SoldierFlyweight
    {
        public SoldierFlyweight(string soldierType, int experienceLevel, int speed, int strength)
        {
            SoldierType = soldierType;
            ExperienceLevel = experienceLevel;
            Speed = speed;
            Strength = strength;
        }

        public string SoldierType { get; private set; }
        public int ExperienceLevel { get; private set; }
        public int Speed { get; private set; }
        public int Strength { get; private set; }

        public void Eliminate(int soldierId)
        {
            Console.WriteLine($"{SoldierType} {soldierId} has been eliminated.");
        }
    }
}
