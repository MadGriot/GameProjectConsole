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
        Miniya.attributes.Strength = 12;


    }
}