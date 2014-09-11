using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarering av variabler
            double totalSum;
            double roundingOfAmount;
            uint costumersAmount;
            uint toPay;
            uint change;

            while (true)
            {
                try
                {
                    //Värden från tangentbordet läses in.  
                    Console.Write("Ange totalsumma     : ");
                    totalSum = double.Parse(Console.ReadLine());
                   
                    if(totalSum <1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }
            



            while (true)
            {
                try
                {
                    //Värden från tangetbordet läses in
                    Console.Write("Ange erhållet belopp: ");
                    costumersAmount = uint.Parse(Console.ReadLine());
                    toPay = (uint)Math.Round(totalSum);
                    if (toPay < totalSum)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }

                    else 
                    {
                        break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }
            toPay = (uint)Math.Round(totalSum);
            roundingOfAmount = toPay - totalSum;

            change = costumersAmount - toPay;

            //Uträkningar görs och skriver ut ett kvitto
            Console.WriteLine("\nKVITTO ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt\t\t: {0:c} \t", totalSum);
            Console.WriteLine("Öresavrundning\t: {0:c} \t", roundingOfAmount);
            Console.WriteLine("Att betala\t: {0:c0} \t", toPay);
            Console.WriteLine("Kontant \t: {0:c0} \t", costumersAmount);
            Console.WriteLine("Tillbaka \t: {0:c0} \t", change);
            Console.WriteLine("---------------------------");

            if (change > 500)

            { 
                Console.WriteLine"500-lappar\t\t: {0}", 
            }
        }
    }
}


