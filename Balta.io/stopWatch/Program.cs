﻿using System;
using System.Threading;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja cronometrar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            
            if(time == 0)
                System.Environment.Exit(0);
        
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            
            Start(time);
        }

        static void Start(int time)
        {
            int currentTme = 0;
            
            while (currentTme != time)
            {
                Console.Clear();
                currentTme++;
                Console.WriteLine(currentTme);
                Thread.Sleep(1000); 
            }
            Console.Clear();
            Console.WriteLine("StopWatch fnalizado...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}