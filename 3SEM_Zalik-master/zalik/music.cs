using System;

namespace zalik
{
    public class music : iskus
    {
        protected string key;
        public music(string name, string nazv, int data, string key) : base(name, nazv, data)
        {//there is some things for description
            this.name = name;
            this.nazv = nazv;
            this.data = data;
            this.key = key;
        }
        public string Key
        {
            get { return key; }
            set { if (key != null) key = value; }
        }
        public new void ekran()
        {
            Console.WriteLine($"Author: {name}, Name: {nazv}, Year: {data}, Tune: {key}");
        }
    }
}