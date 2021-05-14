namespace lab_4
{
    public class Tablet
    {
        public string Model, Processor;
        public int Battery, Camera, Memory;
        public double Diagonal;
        public bool Supp5G, SuppPen;
        public double GetWorkTime()
        {
            return Battery / Diagonal / 24;
        }
    }
}