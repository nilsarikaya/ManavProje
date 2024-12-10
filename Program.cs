using System;
using System.Collections.Generic;

namespace ConsoleApp14
{

    class Program
    {
        static void Main()
        {

            Dictionary<string, int> halMeyveler = new Dictionary<string, int>
        {
            { "Elma", 500 },
            { "Armut", 500 },
            { "Çilek", 500 }
        };

            Dictionary<string, int> halSebzeler = new Dictionary<string, int>
        {
            { "Domates", 500 },
            { "Salatalık", 500},
            { "Havuç", 500 }
        };

            Dictionary<string, int> manavMeyveler = new Dictionary<string, int>();
            Dictionary<string, int> manavSebzeler = new Dictionary<string, int>();
            Dictionary<string, int> musteri = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ.\nMeyve için M, Sebze için S'yi tuşlayınız: ");
                string secim = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (secim == "M")
                {

                    foreach (var meyve in halMeyveler)
                    {
                        Console.WriteLine($"{meyve.Key} - {meyve.Value} kg");
                    }

                    Console.WriteLine("Manav için bir meyve seçiniz:");
                    string meyveSecim = Console.ReadLine();

                    if (halMeyveler.ContainsKey(meyveSecim))
                    {
                        Console.WriteLine("Kaç kilo almak istiyorsunuz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (halMeyveler[meyveSecim] >= kilo)
                        {
                            halMeyveler[meyveSecim] -= kilo;
                            if (!manavMeyveler.ContainsKey(meyveSecim))
                                manavMeyveler[meyveSecim] = 0;

                            manavMeyveler[meyveSecim] += kilo;
                            Console.WriteLine($"{kilo} kg {meyveSecim} manava eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Toptancıda yeterli miktar yok.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçtiğiniz meyve bulunamadı.");
                    }
                }
                else if (secim == "S")
                {
                    Console.WriteLine("Toptancının sebze listesi:");
                    foreach (var sebze in halSebzeler)
                    {
                        Console.WriteLine($"{sebze.Key} - {sebze.Value} kg");
                    }

                    Console.WriteLine("Manav için bir sebze seçiniz:");
                    string sebzeSecim = Console.ReadLine();

                    if (halSebzeler.ContainsKey(sebzeSecim))
                    {
                        Console.WriteLine("Kaç kilo almak istiyorsunuz?");
                        int kilo = int.Parse(Console.ReadLine());

                        if (halSebzeler[sebzeSecim] >= kilo)
                        {
                            halSebzeler[sebzeSecim] -= kilo;
                            if (!manavSebzeler.ContainsKey(sebzeSecim))
                                manavSebzeler[sebzeSecim] = 0;

                            manavSebzeler[sebzeSecim] += kilo;
                            Console.WriteLine($"{kilo} kg {sebzeSecim} manava eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Toptancıda yeterli miktar yok.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçtiğiniz sebze bulunamadı.");
                    }
                }

                Console.WriteLine("Başka bir arzunuz var mı? (Evet için E, Hayır için H)");
                string devam = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (devam == "H")
                    break;
            }

            while (true)
            {
                Console.WriteLine("MANAVA HOŞGELDİNİZ.\nMeyve için M, Sebze için S'ye basınız:");
                string secim = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (secim == "M")
                {

                    foreach (var meyve in manavMeyveler)
                    {
                        Console.WriteLine($"{meyve.Key} - {meyve.Value} kg");
                    }

                    Console.WriteLine("Müşteri için bir meyve seçiniz:");
                    string meyveManavSecim = Console.ReadLine();

                    if (manavMeyveler.ContainsKey(meyveManavSecim))
                    {
                        Console.WriteLine("Kaç kilo almak istiyorsunuz?");
                        int kilo = int.Parse(Console.ReadLine());

                        if (manavMeyveler[meyveManavSecim] >= kilo)
                        {
                            manavMeyveler[meyveManavSecim] -= kilo;
                            if (!musteri.ContainsKey(meyveManavSecim))
                                musteri[meyveManavSecim] = 0;

                            musteri[meyveManavSecim] += kilo;
                            Console.WriteLine($"{kilo} kg {meyveManavSecim} müşteriye eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Manavda yeterli miktar yok.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçtiğiniz meyve bulunamadı.");
                    }
                }
                else if (secim == "S")
                {
                    Console.WriteLine("Manavın sebze listesi:");
                    foreach (var sebze in manavSebzeler)
                    {
                        Console.WriteLine($"{sebze.Key} - {sebze.Value} kg");
                    }

                    Console.WriteLine("Müşteri için bir sebze seçiniz:");
                    string sebzeSecimManav = Console.ReadLine();

                    if (manavSebzeler.ContainsKey(sebzeSecimManav))
                    {
                        Console.WriteLine("Kaç kilo almak istiyorsunuz?");
                        int kilo = int.Parse(Console.ReadLine());

                        if (manavSebzeler[sebzeSecimManav] >= kilo)
                        {
                            manavSebzeler[sebzeSecimManav] -= kilo;
                            if (!musteri.ContainsKey(sebzeSecimManav))
                                musteri[sebzeSecimManav] = 0;

                            musteri[sebzeSecimManav] += kilo;
                            Console.WriteLine($"{kilo} kg {sebzeSecimManav} müşteriye eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Manavda yeterli miktar yok.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçtiğiniz sebze bulunamadı.");
                    }
                }

                Console.WriteLine("Başka bir arzunuz var mı? (Evet için E, Hayır için H)");
                string devam = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (devam == "H")
                    break;
            }

            Console.WriteLine("Müşteri listesi:");
            foreach (var urun in musteri)
            {
                Console.WriteLine($"{urun.Key} - {urun.Value} kg");
            }

            Console.WriteLine("Teşekkür ederiz!");
        }
    }

}
