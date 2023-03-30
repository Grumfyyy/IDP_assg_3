namespace IDP_assg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 2
            Grundämne syre = new Grundämne() { namn = "Syre", Z = 8, typ = "Ickemetall", smältpunkt = 54.36, kokpunkt = 90.188 };
            Grundämne järn = new Grundämne() { namn = "Järn", Z = 26, typ = "Metall", smältpunkt = 1811, kokpunkt = 3134 };
            Grundämne guld = new Grundämne() { namn = "Guld", Z = 8, typ = "Metall", smältpunkt = 1337.33, kokpunkt = 3243 };

            //Uppgift 3
            syre.Print();
            järn.Print();
            guld.Print();
        }

    }

    public class Grundämne
    {
        public string namn;
        public int Z;
        public string typ;
        public double smältpunkt;
        public double kokpunkt;

        public void Print()
        {
            Console.WriteLine($"Grundämne : {this.namn}");
            Console.WriteLine($"Typ : {this.typ}");
            Console.WriteLine($"Smältpunkt : {this.smältpunkt} K");
            Console.WriteLine($"Kokpunkt : {this.kokpunkt} K");
        }
    }
}