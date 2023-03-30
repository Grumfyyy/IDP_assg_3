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
            //syre.Print();
            //järn.Print();
            //guld.Print();

            //Uppgift 4
            Grundämne[] grundämnen = new Grundämne[] { syre, järn, guld,
                                                        new Grundämne() { namn = "Väte", Z = 1, typ = "Ickemetall", smältpunkt = 13.99, kokpunkt = 20.271 },
                                                        new Grundämne() { namn = "Brom", Z = 35, typ = "Ickemetall", smältpunkt = 265.8, kokpunkt = 332.0 },
                                                        new Grundämne() { namn = "Kvicksilver", Z = 80, typ = "Metall", smältpunkt = 234.3210, kokpunkt = 629.88 }
                                                        };

            //Uppgift 5
            /*foreach (Grundämne grundämne in grundämnen)
            {
                grundämne.Print();
            }*/

            //Uppgift 6
            foreach (Grundämne grundämne in grundämnen)
            {
                if(grundämne.typ == "Metall")
                {
                    grundämne.Print();
                }
            }
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