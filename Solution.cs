﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace intro_3
{ 
    internal class Solution
    {
        public void Uppgift_1A()
        {

            Console.WriteLine("hej vad är ditt namn?");
            Console.WriteLine("");
            string namn = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("hej och välkommen " + namn + "!");
            Console.WriteLine();
            double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd;
            Console.WriteLine("rektangel");
            Console.WriteLine("breed:" + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
        }
        public void Uppgift_1C() { 
            //Fråga om tal
            Console.WriteLine("skriv in bredd: ");
            // läs in tal som text
            String text1 = Console.ReadLine();
            // omvandla text till decimaltal
            double bredd = Convert.ToDouble(text1);
            Console.WriteLine("skriv in Höjd: ");
            // läs in tal som text
            String text2 = Console.ReadLine();
            // omvandla text till decimaltal
            double höjd = Convert.ToDouble(text2);
            Console.WriteLine("Triangel");
            Console.WriteLine("Höjd: " + höjd);
            Console.WriteLine("Bredd: " + bredd);
            Console.WriteLine("Area: " + bredd * höjd / 2);
        }
        public void Uppgift_1D()
        {
            Console.WriteLine("Ange ett heltal: ");
            // läs in tal som text
            String tex1 = Console.ReadLine();
            // omvandla text till heltal
            int tal1 = Convert.ToInt32(tex1);
            Console.WriteLine("Ange ett heltal till: ");
            // läs in tal som text
            String tex2 = Console.ReadLine();
            // omvandla text till heltal
            int tal2 = Convert.ToInt32(tex2);
            int sum = tal1 + tal2;
            Console.WriteLine("Summan av talen: " + sum);
        }

        public void Uppgift_2A() {
            Console.WriteLine("Gissa mitt favorittal");
            var text = Console.ReadLine();
            double tal = Convert.ToDouble(text);
            if (tal == 5)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else
            {
                Console.Write("Du gissade fel!");
            }

        }
        public void Uppgift_2B() {
            Random randomgenerator1 = new Random();
            int antalTärningsögon1 = randomgenerator1.Next(1, 7);
            Random randomgenerator2 = new Random();
            int antalTärningsögon2 = randomgenerator2.Next(1, 7);
            Console.WriteLine("Vill du spela tärning? Visar båda samma är det en vinst!");
            var v = Console.ReadLine();
            // || gör att man kan ange flera korrekta svar
            if (v == "ja" || v == "Ja" || v == "JA")
            {
                Console.WriteLine("Tärningarna visar: " + antalTärningsögon1 + " och: " + antalTärningsögon2);
                if (antalTärningsögon2 == antalTärningsögon1)
                {
                    Console.WriteLine("Du vann!");
                }
                else
                {
                    Console.WriteLine("Du förlorade!");
                }



            }
            else
            {
                Console.WriteLine("Okay... Adios then!");
            }






        }
        public void Uppgift_3A()
        {
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }



        }
        public void Uppgift_3B()
        {



            int i = 5;
            while (i < 21)
            {
                Console.WriteLine(i);
                i = i + 3;
            }



        }
        public void Uppgift_3C()
        {
            int i = 10;
            while (i > -1)
            {
                Console.WriteLine(i);
                i = i - 1;
            }

        }
        public void Uppgift_4A()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }
        }



        public void Uppgift_4B()
        {
            for (int i = 5; i < 21; i = i + 3)
            {
                Console.WriteLine(i);
            }





        }

    }
}
