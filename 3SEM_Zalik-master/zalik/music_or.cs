using System;

namespace zalik
{
    public class music_or : music
    {
        protected int kol;
        public music_or(string name, string nazv, int data, string key, int kol) : base(name, nazv, data, key)
        {
            this.name = name;
            this.nazv = nazv;
            this.data = data;
            this.key = key;
            this.kol = kol;
        }
        public int Kol
        {//put smtnh here
            get { return kol; }
            set { if (kol != 0) kol = value; }
        }
        public new void ekran()
        {
            Console.WriteLine($"Author: {name}, Name: {nazv}, Date: {data}, Tune: {key}, Number of musicians: {kol}");
        }
    }
}