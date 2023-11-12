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

        Character Miniya = new Character();
        Miniya.name = "Miniya";
        Miniya.background = Background.Barbarian;
        Miniya.character_class = Class.Warrior;
        mechanics.Free_Skills(Miniya.background, Miniya.character_skills, Miniya.combat_skills);
        mechanics.starting_level(Miniya.attributes, Miniya.character_class);
        Console.WriteLine(Miniya.attributes.hit_points);
    }
}