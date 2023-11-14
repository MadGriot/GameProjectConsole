using CharacterLibrary;
using CombatMechanicsLib;

namespace StatMechanicsLib
{

    internal class StatMechanics
    {
        Random rnd = new Random();
        CombatMechanicsLib.CombatMechanics combatMechanics = new CombatMechanics();

        public double Modifiers(double attribute)
        {
            double modifier = 0.0;
            if (attribute <= 3)
                modifier = -2;
            else if (attribute > 3 && attribute < 8)
                modifier = -1;
            else if (attribute > 7 && attribute < 14)
                modifier = 0;
            else if (attribute > 13 && attribute < 18)
                modifier = 1;
            else if (attribute == 18)
                modifier = 2;
            else
                modifier = 2;
            while (attribute > 18)
            {
                modifier++;
                attribute = attribute - 4;
            }

            return modifier;

        }

        public double D_4 ()
        {
            return rnd.Next(1, 5);
        }
        public double D_6 ()
        {
            return rnd.Next(1, 7);
        }

        public double D_8 ()
        {
            return rnd.Next(1, 9);
        }

        public double D_10 ()
        {
            return rnd.Next(1, 11);
        }

        public double D_12 ()
        {
            return rnd.Next(1, 13);
        }

        public double D_20 ()
        {
            return rnd.Next(1, 21);
        }

        public double D_100 ()
        {
            return rnd.Next(1, 101);
        }

        public void Free_Skills (Background background, Skills skills, Skills.Combat combat)
        {
            switch (background)
            {

                case Background.Barbarian:
                    skills.Survive += 1;
                    combat.Melee_Weapons += 1;
                    break;

                case Background.Clergy:
                    skills.Know += 1;
                    skills.Persuasion += 1;
                    break;

                case Background.Courtesan:
                    skills.Perform += 1;
                    skills.Connect += 1;
                    break;

                case Background.Criminal:
                    skills.Sneak += 1;
                    skills.Connect += 1;
                    break;

                case Background.Dilettante:
                    skills.Connect += 1;
                    skills.Persuasion += 1;
                    break;

                case Background.Entertainer:
                    skills.Perform += 1;
                    skills.Work += 1;
                    break;

                case Background.Merchant:
                    skills.Trade += 1;
                    skills.Connect += 1;
                    break;

                case Background.Noble:
                    skills.Lead += 1;
                    skills.Administer += 1;
                    break;

                case Background.Official:
                    skills.Administer += 1;
                    skills.Persuasion += 1;
                    break;

                case Background.Peasant:
                    skills.Exert += 1;
                    skills.Survive += 1;
                    break;

                case Background.Physician:
                    skills.Heal += 1;
                    skills.Know += 1;
                    break;

                case Background.Pilot:
                    skills.Pilot += 1;
                    skills.Fix += 1;
                    break;

                case Background.Politician:
                    skills.Persuasion += 1;
                    skills.Lead += 1;
                    break;

                case Background.Scholar:
                    skills.Know += 1;
                    skills.Administer += 1;
                    break;

                case Background.Soldier:
                    combat.Marksmanship += 1;
                    combat.Martial_Arts += 1;
                    break;

                case Background.Spacer:
                    skills.Fix += 1;
                    skills.Program += 1;
                    break;

                case Background.Technician:
                    skills.Fix += 1;
                    skills.Exert += 1;
                    break;

                case Background.Thug:
                    combat.Martial_Arts += 1;
                    skills.Connect += 1;
                    break;

                case Background.Vagabond:
                    skills.Survive += 1;
                    skills.Notice += 1;
                    break;

                case Background.Worker:
                    skills.Work += 1;
                    skills.Exert += 1;
                    break;
            }

        }
        public void Bonus_Skills(Skills skills, Skills.Combat combat_skills, Focus focus)
        {
            if (focus != null && skills != null) 
            {
                if (focus.Alert >= 1)
                    skills.Notice += 1;
                else if (focus.Armsman >= 1)
                    combat_skills.Melee_Weapons += 1;
            }
        }
        public void starting_level(Attributes attributes, Class character_class)
        {
            if (attributes.level == 0)
            {
                attributes.level += 1;
                attributes.hit_points += 3;
                double con_modifier = Modifiers(attributes.Constitution);
                if (con_modifier > 0)
                    attributes.hit_points += con_modifier;

                attributes.attack_bonus = attributes.level / 2;

                switch (character_class)
                {
                    case Class.Warrior:
                        attributes.hit_points += 2;
                        break;
                }
            }
        }

        public void Focus_Check(Focus focus, Character character)
        {
            if (focus.Alert == 1)
            {
                double initiative_roll = combatMechanics.initiative(character.attributes);
                double initiative_roll2 = combatMechanics.initiative(character.attributes);

                double final_result = (initiative_roll > initiative_roll2) ? initiative_roll : initiative_roll2;
                character.attributes.initiative = final_result;
            }
            else if (focus.Alert == 2)
            {
                double initiative_roll = combatMechanics.initiative(character.attributes);
                double initiative_roll2 = combatMechanics.initiative(character.attributes);

                double final_result = (initiative_roll > initiative_roll2) ? initiative_roll : initiative_roll2;
                character.attributes.initiative = final_result + 3;
            }
        }
    }
}
