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

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(mechanics.D_8());
        }

    }
}