using System;

namespace RettangoloParse
{
    internal class Rettangolo
    {
        public int L1 { get; set; }
        public int L2 { get; set; }

        public Rettangolo(int l1, int l2)
        {
            this.L1 = l1;
            this.L2 = l2;
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", L1, L2);
        }

        public static Rettangolo Parse(string s)
        {
            string[] parts = s.Split(';');
            return new Rettangolo(int.Parse(parts[0]), int.Parse(parts[1]));    
        }
    }
}