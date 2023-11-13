using StatMechanicsLib;
using CharacterLibrary;

namespace CombatMechanicsLib
{
    internal class CombatMechanics
    {
        StatMechanics mechanics = new StatMechanics();
        public double initiative(Attributes attributes)
        {
            double initiative_roll = mechanics.Modifiers(attributes.Dexterity) + mechanics.D_8();
            return initiative_roll;
        }
    }
}
