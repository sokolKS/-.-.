namespace lab_6
{
    public class Tablet
    {
        public string Model { get; set; }
        public string Processor { get; set; }
        public int Battery { get; set; }
        public int Camera { get; set; }
        public int Memory { get; set; }
        public double Diagonal { get; set; }
        public bool Supp5G { get; set; }
        public bool SuppPen { get; set; }
        public double GetWorkTime()
        {
            return Battery / Diagonal / 24;
        }
        public Tablet()
        {
        }

        public Tablet(string model, string processor, int battery, int camera,
        int memory, double diagonal, bool supp5G, bool suppPen)
        {
            Model = model;
            Processor = processor;
            Battery = battery;
            Camera = camera;
            Memory = memory;
            Diagonal = diagonal;
            Supp5G = supp5G;
            SuppPen = suppPen;
        }
    }
}