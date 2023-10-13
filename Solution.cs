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
        
        
        
        }
    }
}
