using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            BitString bitString = new BitString();
            bitString.AddBits("0000");
            bitString.FilledWithZeros += String_FilledWithZeros;

            bitString.CheckString();

            Console.WriteLine(bitString.ToString());
        }
        private static void String_FilledWithZeros(object sender, EventArgs e)
        {
            BitString bitString = (BitString)sender;
            Console.WriteLine("BitString is filled with zeros.");

            bitString.ReplaceChar(bitString.Length() - 1, '1');
        }
    }
}
