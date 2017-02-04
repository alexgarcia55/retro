using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackaThon_Retro
{
    public class PhongNguyen
    {
        public void Print()
        {
            Console.WriteLine("Hackathon");
        }
        public string Encrypt(string pass)
        {
            string hidden;
            hidden = pass;
            foreach(char c in hidden)
            {

            }
            return hidden;
        }
        public void FileOut()
        {

        }
        public void FileIn(string encryption, System.IO.StreamWriter File)
        {
            File.WriteLine(encryption);
        }
            
    }
}
