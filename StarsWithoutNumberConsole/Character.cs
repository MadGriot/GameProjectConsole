namespace CharacterLibrary
{
    public struct Attributes
    {
        public double Strength;
        public double Dexterity;
        public double Constitution;
        public double Intelligence;
        public double Wisdom;
        public double Charisma;
    }


    struct Skills
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
        public int Martial_Arts;
        public int Marksmanship;
        public int Sneak;
        public int Melee_Weapons;
        public int Survive;
        public int Persuasion;
        public int Trade;
        public int Work;
    }

    struct Phychic_Skills
    {
        public int Biopsionics;
        public int Metapsionics;
        public int Precognition;
        public int Telekinesis;
        public int Telepathy;
        public int Teleportation;
    }
    enum Background
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
    public class Character
    {
        public Attributes attributes = new Attributes();
        Skills character_skills = new Skills();
        Phychic_Skills phychic_skills = new Phychic_Skills();
        Background background;

    }
}
