using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak1
{
    class Program
    {
        delegate int Delegalt(int a, int b);
        static void Main(string[] args)
        {
            Delegalt anon_osszead = delegate (int a, int b) { return a + b; };
            Delegalt osszead = (a, b) => { return a + b; };
            Delegalt kivonas = kivon;
            Console.WriteLine(anon_osszead(1, 2));
            Console.WriteLine(osszead(1, 2));
            Console.WriteLine(kivonas(1, 2));
            Delegalt alapmuveletek = (a, b) => { return a + b; };
            alapmuveletek += (a, b) => { return a - b; };
            alapmuveletek += (a, b) => { return a * b; };
            alapmuveletek += (a, b) => { return a / b; };
            Console.WriteLine(alapmuveletek(1, 2));
            Console.ReadKey();
        }
        static int kivon(int a, int b) { return a - b; }
    }
}
