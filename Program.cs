using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjectTraning
{
    class Program
    {
       class Contry
        {
          public  string name;
          public  City capital;
            string popuation;
        }
        class City
        {
           public string name;
            string popuation;
        }
        static void Main(string[] args)
        {
            City Stockholm = new City();
            Contry Sverige = new Contry();
            Sverige.capital = Stockholm;

            Console.ReadKey();
            
        }
    }
}
