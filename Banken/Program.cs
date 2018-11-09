using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {

        static void Main(string[] args)
        {
            //Lista för kundernas Namn och pengar.
            List<Kund> list = new List<Kund>();

            ///läs från fil och lägg in i list (dvs listan av kunder)
            bank(list);
            //alternativ frågor till användaren.  
            Console.WriteLine("Välkommern till 'Banken som man ska inte lita på' ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1: Lägga till en kund: \n");
            Console.WriteLine("2: Ta bort en kund: \n");
            Console.WriteLine("3: Visa alla befintliga kunder: \n");
            Console.WriteLine("4: Visa saldo för  kund/kunder: \n");
            Console.WriteLine("5: Gör en insättning för kund: \n");
            Console.WriteLine("6: Gör ett uttag för en kund: \n");
            Console.WriteLine("7: Tryck 7 för att vsluta programmet: ");
            int val = int.Parse(Console.ReadLine());



            while (val != 7)
            {
                switch (val)
                {
                    case 1:
                        //Mata in kunders Namn.
                        Console.WriteLine(" Mata in en kund");
                        Kund kund1 = new Kund();
                        kund1.namn = Console.ReadLine();
                        list.Add(kund1);
                        break;


                    case 2:
                        //Att kunna ta bort kund från listan.
                        Console.WriteLine("Mata in en kund att ta bort:");
                        string Namn = Console.ReadLine();
                        Kund kund = null;
                        foreach (Kund info in list)
                        {
                            if (info.namn == Namn)
                            {
                                kund = info;
                            }
                        }
                        list.Remove(kund);
                        break;

                    case 3:
                        //Att kunna se alla befintliga kunder.
                        Console.WriteLine("Alla befintliga Kunder...");
                        foreach (Kund info in list)
                        {
                            File.WriteAllText(Filename, info.showkund());
                        }
                        break;

                    case 4:
                        Console.WriteLine("Vilken kunds saldo vill du se?");
                        int Saldo = int.Parse(Console.ReadLine());
                        Kund saldo = null;
                        foreach (Kund info in list)
                        {
                            if (info.saldo == Saldo)
                            {
                                kund = info;
                            }
                        }
                        Console.WriteLine(Saldo);
                        break;

                    case 5:
                        Console.WriteLine("Hur mycket pengar vill du sätta in?");
                        break;

                    case 6:
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        break;


                    case 7:
                        //För att kunna stänga programmet.
                        Console.WriteLine("DU valde 7 för att stänga programet");
                        break;
                }
                val = int.Parse(Console.ReadLine());
            }

        }

        static void WriteFile(string Filename,  List<Kund> list)
        {
            foreach (Kund info in list)
            {
                Console.WriteLine(info.Visakund());
            }

        }

        static void ReadFile(string Filename)
        {
            string text = File.ReadAllText(Filename);

        }

        static void bank(List<Kund> list)
        {
            string Filename = @"C:\bank.filhantering\kunder.txt";

            WriteFile(Filename);
            ReadFile(Filename);

            Console.ReadKey();
        }
    }
}
