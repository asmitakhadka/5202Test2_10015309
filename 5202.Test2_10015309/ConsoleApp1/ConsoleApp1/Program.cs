using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            askbirdname();
            askbirdspecies();
            askbirdsex();
            askbirdweight();
            askbirdbandno();
            askbirdoutput();
            askbird();
        }
        
        public static void askbirdname()
        {
           

            Console.WriteLine("Please enter the bird name ");
            Console.ReadLine();
        } 
        public static void askbirdspecies()
        {
            Console.WriteLine("Please enter the bird species ");
            Console.ReadLine();
        }
        public static void askbirdsex()
        {
            Console.WriteLine("Please enter the bird sex ");
            Console.ReadLine();
        }
        public static void askbirdweight()
        {
           Console.WriteLine("Please enter the bird weight ");
           Console.ReadLine();
        }
        public static void askbirdbandno()
        { 
            Console.WriteLine("Please enter the bird bandno ");
            Console.ReadLine();
        }
        public static void askbird()
        {
           
            Console.WriteLine("Information about the New Zealand Birds of Prey that have rescused and banded");
            Console.WriteLine("Bird object created and default data loaded...");

            Console.WriteLine("Please Update Bird Data");
          
        }
        public static void askbirdoutput()
        {
            Console.WriteLine("BIRD OF PERY DATA OUTPUT");
            Console.WriteLine("Bird Name: Hisan");
            Console.WriteLine("Bird Species: Nz Falcon");
            Console.WriteLine("Bird Sex: Male");
            Console.WriteLine("Bird Weight: 240grams");
            Console.WriteLine("Bird Bandno: H39878");
        }
        
    }
}
