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
        class Person
        {
            public string förnamn, efternamn, hemtelefon, jobbtelefon;
            public Person(string S,string E,string H, string J)
            {
                förnamn = S;
                efternamn = E;
                hemtelefon = H;
                jobbtelefon = J;
            }
            public void Print()
            {
                Console.WriteLine("{0} {1} {2} {3}", förnamn, efternamn, hemtelefon, jobbtelefon);
                    
            }
        }
        static void Main(string[] args)
        {
            Person Arne = new Person("arne", "saknusem", "1233315513", "75345644564253");
            Arne.Print();
            Console.ReadKey();
        }
    }
}
