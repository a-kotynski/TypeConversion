using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //implicit type conversion
            byte b = 1; //                                                         00000001
            int i = b;  //                     00000000    00000000    00000000    00000001
            */

            /*
            //implicit type conversion 2
            int i = 1;
            float f = i;
            */

            /*
            //explicit type conversion
            int i = 1;
            //byte b = i; //doesn't compile
            byte b = (byte)i;
            */

            /*
            //explicit type conversion 2
            float f = 1.0f;
            int i = (int)f; 
            */

            /*
            //non-compatible types
            string s = "1";
            int i = (int)s; //doesn't compile
            */

            /*
            //non-compatible types 2 using Convert.ToInt32() and Parse()
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("{0} {1}", i, j);
            Console.ReadLine();
            */

            //Conversion methods:
            //ToByte()
            //ToInt16()
            //ToInt32()
            //ToInt64()
        }
    }
}