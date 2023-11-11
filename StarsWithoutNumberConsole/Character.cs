namespace CharacterLibrary
{
    public class Attributes
    {
        public double Strength;
        public double Dexterity;
        public double Constitution;
        public double Intelligence;
        public double Wisdom;
        public double Charisma;
    }


    public class Skills
    {

        public int Administer;
        public int Connect;
        public int Exert;
        public int Fix;
        public int Heal;
        public int Know;
        public int Lead;
        public int Notice;
        public int Perform;
        public int Pilot;
        public int Program;
        public int Sneak;
        public int Survive;
        public int Persuasion;
        public int Trade;
        public int Work;
        public class Combat
        {
            public int Martial_Arts;
            public int Marksmanship;
            public int Melee_Weapons;
        }

        public class Phychic
        {
            public int Biopsionics;
            public int Metapsionics;
            public int Precognition;
            public int Telekinesis;
            public int Telepathy;
            public int Teleportation;
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
    public class Character
    {
        public Attributes attributes = new Attributes();
        public Skills character_skills = new Skills();
        public Skills.Combat combat_skills = new Skills.Combat();
        public Skills.Phychic phychic_skills = new Skills.Phychic();
        public Background background;
        public Class character_class;

    }
}
