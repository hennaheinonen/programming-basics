﻿using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Define instructions

            Console.WriteLine("Ohjemlma asettaa luvut suuruusjärjestykseen");

            Console.WriteLine("Syötä Numero 1:");
            string numero1 = Console.ReadLine();
            int numx = int.Parse(numero1);

            Console.WriteLine("Syötä Numero 2:");
            string numero2 = Console.ReadLine();
            int numy = int.Parse(numero2);

            Console.WriteLine("Syötä Numero 3:");
            string numero3 = Console.ReadLine();
            int numz = int.Parse(numero3);

            if (numx < numy)
            {
                if (numx < numz)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"järjestys on : {numx}, {numy}, {numz}");
                    }
                    else
                    {
                        Console.WriteLine($"järjestys on : {numz}, {numy}, {numx}");
                    }
                }
                else
                {
                    Console.WriteLine($"järjestys on : {numz}, {numx}, {numy}");
                }

            }
            else
            {
                if (numx < numz)
                {
                    if (numy < numz) 
                    {
                        Console.WriteLine($"järjestys on : {numy}, {numx}, {numz}");
                    }
                    else
                    {
                        Console.WriteLine($"järjestys on : {numy}, {numz}, {numx}");
                    }    
                }
                else 
                {
                    Console.WriteLine($"järjestys on : {numz}, {numy}, {numx}");
                }    
            }    
 



            Console.WriteLine($"{numx}, {numy}, {numz}");
			Console.ReadKey();
        }
    }
}