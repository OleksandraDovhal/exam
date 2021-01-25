using System;

namespace zalik
{
    class Program
    {
        static void Main(string[] args)
        {
            //music art???
            string name1 = "Betsy Schwarm";
            string nazv1 = "1O1";
            int data1 = 1989;
            iskus _name1 = new iskus(name1, nazv1, data1);
            _name1.ekran();
            Console.WriteLine();

            string name2 = "The Red Pony";
            string nazv2 = "Copland";
            int data2 = 1949;
            string key2 = "American Ballads";
            music _name2 = new music(name2, nazv2, data2, key2);
            _name2.ekran();
            Console.WriteLine();
            
            //orcestra art
            string name3 = "Concerto for Saxophone Quartet and Orchestra";
            string nazv3 = "Glass";
            int data3 = 1967;
            string key3 = "Tenor";
            int kol3 = 10;
            music_or _name3 = new music_or(name3, nazv3, data3, key3, kol3);
            _name3.ekran();
            Console.WriteLine();
            //painting
            string name4 = "Pablo picasso";
            string nazv4 = "Guernica";
            int data4 = 1937;
            int h4 = 1280;
            int w4 = 720;
            kart _name4 = new kart(name4, nazv4, data4, h4, w4);
            _name4.ekran();
        }
    }
}
