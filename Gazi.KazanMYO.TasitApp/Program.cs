using Tasit;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMYO.TasitApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç Araba Girmek İstiyorsunuz:");
            int arabasayisi = int.Parse(Console.ReadLine());

            Araba[] araba = new Araba[arabasayisi];

            for (int i = 0; i < arabasayisi; i++)
            {
                araba[i] = new Araba();
                Console.WriteLine("Araba markasını girin " + (i + 1) + "\t");
                araba[i].Marka = Console.ReadLine();

                Console.WriteLine("Arabanın modelini girin " + (i + 1) + "\t");
                araba[i].Model = Console.ReadLine();

                Console.WriteLine("Arabanın rengini giriniz " + (i + 1) + "\t");
                araba[i].Tasitrengi = Console.ReadLine();

                Console.WriteLine("En fazla alınabilecek yolcu sayısı " + (i + 1) + "\t");
                araba[i].Yolcusayisi = byte.Parse(Console.ReadLine());

                Console.WriteLine("Kaç Kapılı " + (i + 1) + "\t");
                araba[i].Kapisayisi = byte.Parse(Console.ReadLine());

                Console.WriteLine("Maksimum hızı giriniz" + (i + 1) + "\t");
                araba[i].Maxhiz = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arabasayisi; i++)
            {
                string path = @"Desktop\Arabalar.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(araba[i].Marka + "\t" + araba[i].Model + "\t" + araba[i].Tasitrengi + "\t" + araba[i].Yolcusayisi + "\t" + araba[i].Kapisayisi + "\t" + araba[i].Maxhiz);
                    }

                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
            }
        }
    }
}
