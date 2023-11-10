namespace StatMechanicsLib
{

    internal class StatMechanics
    {
        Random rnd = new Random();
        public double Modifiers(double attribute)
        {
            double modifier = 0.0;
            if (attribute == 3)
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
    }
}
