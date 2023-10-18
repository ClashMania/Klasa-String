using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string tekst = "Danas radimo sa klasom String.";

            //Ispis stringa
            Console.WriteLine(tekst);


            //broj znakova u stringu
            Console.WriteLine("\nBroj znakova je : " + tekst.Length);

            //Ispis velikim slovima
            Console.WriteLine("\nVelika slova: " + tekst.ToUpper());


            //Ispis malim slovima
            Console.WriteLine("\nMala slova: " + tekst.ToLower());


            //substring metoda
            Console.WriteLine("\n ***** Substring metoda ******");
            Console.Write(tekst.Substring(0, 5));
            Console.Write(tekst.Substring(14, tekst.Length - 14));

            //Zamjena
            Console.WriteLine("\n");
            Console.WriteLine(tekst.Replace("Danas", "Sutra"));

            //razdvajanje

            Console.WriteLine("\n ***** Razdvajanje ******");
            string[] rijeci = tekst.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }
            foreach (string rijec in rijeci) 
            {  
                Console.WriteLine(rijec); 
            }


            //umetanje znakova u string
            Console.WriteLine("\n ****** Umetanje ******");
            Console.WriteLine(tekst.IndexOf("radimo"));

            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"),("intenzivno ")));







            Console.ReadKey();

        }
    }
}
