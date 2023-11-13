
namespace CharacterLibrary
{
    public class Attributes
    {
        public double hit_points;
        public int level;
        public double attack_bonus;
        public double armor_class;
        public double Strength;
        public double Dexterity;
        public double Constitution;
        public double Intelligence;
        public double Wisdom;
        public double Charisma;
    }


    public class Skills
    {

        public int Administer = -1;
        public int Connect = -1;
        public int Exert = -1;
        public int Fix = -1;
        public int Heal = -1;
        public int Know = -1;
        public int Lead = -1;
        public int Notice = -1;
        public int Perform = -1;
        public int Pilot = -1;
        public int Program = -1;
        public int Sneak = -1;
        public int Survive = -1;
        public int Persuasion = -1;
        public int Trade = -1;
        public int Work = -1;
        public class Combat
        {
            public int Martial_Arts = -1;
            public int Marksmanship = -1;
            public int Melee_Weapons = -1;
        }

        public class Phychic
        {
            public int Biopsionics = -1;
            public int Metapsionics = -1;
            public int Precognition = -1;
            public int Telekinesis = -1;
            public int Telepathy = -1;
            public int Teleportation = -1;
        }
    }
    public enum Background
    {
        Barbarian,
        Clergy,
        Courtesan,
        Criminal,
        Dilettante,
        Entertainer,
        Merchant,
        Noble,
        Official,
        Peasant,
        Physician,
        Pilot,
        Politician,
        Scholar,
        Soldier,
        Spacer,
        Technician,
        Thug,
        Vagabond,
        Worker,
    }

    public enum Class
    {
        Expert,
        Psychic,
        Warrior,
    }

    public class Focus
    {
        public int Alert;
        public int Armsman;
        public int Assassin;
        public int Authority;
        public int Close_Combatant;
        public int Connected;
        public int Die_Hard;
        public int Diplomat;
        public int Gunslinger;
        public int Hacker;
        public int Healer;
        public int Henchkeeper;
        public int Ironhide;
        public int Phychic_Training;
        public int Savage_Fray;
        public int Sniper;
        public int Specialist;
        public int Star_Captain;
        public int Starfarer;
        public int Tinker;
        public int Unarmed_Combatant;
        public int Wanderer;
        public int Wild_Phychic_Talent;

    }
    public class Character
    {
        public string name = "";
        public Attributes attributes = new Attributes();
        public Skills character_skills = new Skills();
        public Skills.Combat combat_skills = new Skills.Combat();
        public Skills.Phychic phychic_skills = new Skills.Phychic();
        public Background background;
        public Class character_class;
        public Focus focus = new Focus();

    }
}
