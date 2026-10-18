using System;
using System.Collections.Generic;
using System.Text;

namespace AudioBook
{
    internal class AudioBook : ISellable, IDownloadable
    {
        private string name;
        private int price;
        private int sizeGB;

        public AudioBook(string name, int price, int sizeGB)
        {
            this.name = name;
            this.price = price;
            this.sizeGB = sizeGB;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int SizeGB { get => sizeGB; set => sizeGB = value; }

        public void Download()
        {
            Console.WriteLine($"{this.Name} letöltése folyamatban...");
            Thread.Sleep(5000);
            Console.WriteLine($"{this.Name} letöltve!");
        }

        public double GetFileSizeInMB()
        {
            return this.SizeGB*1024;
        }

        public int GetPrice()
        {
            return this.Price;
        }

        public string GetProductName()
        {
            return this.Name;
        }
    }
}
