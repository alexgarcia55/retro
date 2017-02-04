

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackaThon_Retro
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("Password.txt");
            Console.WriteLine("Hello World");
            PhongNguyen p = new PhongNguyen();
            p.Print();
        }
    }
}
