namespace IDP_assg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Uppgift2()
        {
            Grundämne oxygen = new Grundämne() { namn = "Syre", Z = 8, typ = "ickemetall", smältpunkt = 54.36, kokpunkt = 90.188 };
            Grundämne järn = new Grundämne() { namn = "Järn", Z = 26, typ = "metall", smältpunkt = 1811, kokpunkt = 3134};
            Grundämne guld = new Grundämne() { namn = "Guld", Z = 8, typ = "metall", smältpunkt = 1337.33, kokpunkt = 3243 };
        }

    }

    public class Grundämne
    {
        public string namn;
        public int Z;
        public string typ;
        public double smältpunkt;
        public double kokpunkt;
    }
}