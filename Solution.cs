using System;
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

        }
    }
}
