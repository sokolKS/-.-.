using System;

namespace lab_2
{
    class Tablet
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Модель планшета: ");
            string sModel = Console.ReadLine();

            Console.Write("Процесор: ");
            string sProcessor = Console.ReadLine();

            Console.Write("Батарея: ");
            string sBattery = Console.ReadLine();

            Console.Write("Камера: ");
            string sCamera = Console.ReadLine();

            Console.Write("Діагональ: ");
            string sDiagonal = Console.ReadLine();

            Console.Write("Пам'ять: ");
            string sMemory = Console.ReadLine();

            Console.Write("Чи є підтримка 5G? (y-так, n-нi): ");
            ConsoleKeyInfo keySupp5G = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Чи є стилус? (y-так, n-нi): ");
            ConsoleKeyInfo keySuppPen = Console.ReadKey();

            Tablet OurTablet = new Tablet();

            OurTablet.Model = sModel;
            OurTablet.Processor = sProcessor;
            OurTablet.Battery = int.Parse(sBattery);
            OurTablet.Camera = int.Parse(sCamera);
            OurTablet.Memory = int.Parse(sMemory);
            OurTablet.Diagonal = double.Parse(sDiagonal);
            OurTablet.Supp5G = keySupp5G.Key == ConsoleKey.Y ? true : false;
            OurTablet.SuppPen = keySuppPen.Key == ConsoleKey.Y ? true : false;
            double WorkTime = OurTablet.GetWorkTime();

            Console.WriteLine(
            "\n--------------------------" +
            "\n     Дані про об’єкт" +
            "\n--------------------------" +
            "\nМодель: " + OurTablet.Model +
            "\nПроцесор: " + OurTablet.Processor +
            "\nБатарея: " + OurTablet.Battery + " мА*ч" +
            "\nЧас роботи: " + WorkTime.ToString("0.##") + " год" +
            "\nКамера: " + OurTablet.Camera + " Мп" +
            "\nПам'ять: " + OurTablet.Memory + " ГБ" +
            "\nДіагональ: " + OurTablet.Diagonal.ToString("0.00") + "\"" +
            (OurTablet.Supp5G ? "\nЄ 5G" : "\nНемає 5G") +
            (OurTablet.SuppPen ? "\nЄ стилус" : "\nНемає стилусу"));
            Console.ReadKey();
        }
    }
}
