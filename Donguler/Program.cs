﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs", 
                "Java","Python", "c#" };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("footer");
        }
    }
}