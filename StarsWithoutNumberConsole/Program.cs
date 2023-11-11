using CharacterLibrary;
using StatMechanicsLib;

namespace sandbox;

class Program
{
    static void Main(string[] args)
    {
        Character Jafaru = new Character();
        Jafaru.attributes.Strength = 20;
        StatMechanics mechanics = new StatMechanics();
        Console.WriteLine(mechanics.Modifiers(Jafaru.attributes.Strength));

        Character Miniya = new Character();
        Miniya.background = Background.Barbarian;
        mechanics.Free_Skills(Miniya.background, Miniya.character_skills, Miniya.combat_skills);
        Console.WriteLine(Miniya.character_skills.Survive);
        Console.WriteLine(Miniya.combat_skills.Melee_Weapons);
    }
}