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
        class car
        {
             private string carbrand, modelyear;
            private int scandiMiles;
          public car(string B, string Å, int M)
          {
                carbrand = B;
                modelyear = Å;
                scandiMiles = M;

          }
          public int ScandiMiles()
          {
                return scandiMiles;
          }   
            public bool UpdateMiles(int newAmountMiles) 
            {
                if(newAmountMiles< scandiMiles)
                {
                    return false;
                }
                else
                {
                    scandiMiles = newAmountMiles;
                    return true;
                }
            }
          
        }
        static void Main(string[] args)
        {
            
            car B = new car("Lada", "1990",137672);
            Console.WriteLine("antal mil = {0}", B.ScandiMiles());
            if (B.UpdateMiles(237670))
            {
                Console.WriteLine("miltalet uppdaterades");
            }
            else
            { 
                Console.WriteLine("miltalet updaterades inte");
            }
            Console.ReadKey();
        }
    }
}
