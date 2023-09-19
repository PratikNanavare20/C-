using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NUMBERS


            //01 Byte
            /*
             * 
            byte b1 = 255;
            //byte b2 = -128; //-128 value is not between the byte range. 

            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine(Byte.MaxValue);
            Console.WriteLine(Byte.MinValue);
            Console.WriteLine(SByte.MaxValue);
            Console.WriteLine(SByte.MinValue);
            
            */

            //02 Short

            /*
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000; //35000 is gretter than short range or not betweeen the range of short data type

            ushort us1 = 65535;
            //ushort us2 = -35000;

            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);

            */

            //03 Int
            /*
             
            int i1 = -2147483648;
            int i2 = 2147483647;

            uint ui1 = 4294967295;
            // uint ui2 = -1; 

            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt32.MinValue);

            */

            //04 hexa and binary

            /*
            int hexa = 0x2F;
            int bin = 0b_0010_1111;

            Console.WriteLine(hexa);
            Console.WriteLine(bin);
            Console.WriteLine(hexa + bin);
            Console.WriteLine(hexa - bin);
            Console.WriteLine(hexa * bin);
            Console.WriteLine(hexa / bin);
            */

            //05  Long
            /*
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(Int64.MinValue); 
            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(UInt32.MinValue);
            */

            //06 Float
            /*
            float f1 = 123456.5F;
            float f2 = 1.6548237f;

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            */

            //07 Double
            /*
            double d1 = 1636541836573.9d;
            double d2 = 4873274313.43452f;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            */

            //09 Decimal
            /*
            decimal d1 = 42131242441248717240284617124.6m;
            decimal d2 = 1.632856390359923m;

            Console.WriteLine(d1);
            Console.WriteLine(d2);  
            */

            //10 Scientific Notations
            /*
            double d = 0.12e2;

            float f = 123.45e-2f;

            decimal m = 1.2e6m;

            Console.WriteLine(d);   
            Console.WriteLine(f);   
            Console.WriteLine(m);
            */

            //String 
            /*
            string ch = "P";
            string word = "Pratik";
            string text = "My name is Pratik";

            Console.WriteLine(ch);
            Console.WriteLine(word);
            Console.WriteLine(text);
            */
            /*
            char[] chars = { 'P', 'R', 'A', 'T', 'I', 'K'};

            string str1 = new string(chars);

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }

            */
            /*
            string text = "This is a \"string\" in C#."; //

            Console.WriteLine(text);
            */

            /*
            int a = 10;
            int b = 11;
            int c = 11;
            
            if (a > b && a > c)
            {
                Console.WriteLine("The gretter number is "+a);
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("The gretter number is " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The gretter number is " + c);
            }
            else
            {
                Console.WriteLine("All Are same");
            }
            */
            /*
            if (a > b)
            {
                Console.WriteLine("The gretter number is " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("The gretter number is " + b);
            }
            else if (c > a)
            {
                Console.WriteLine("The gretter number is " + c);
            }
            else
            {
                Console.WriteLine("All Are same");
            }
            */

            /*
            string text = "This is a \"5\" in C#."; 
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";

            Console.WriteLine(text);
            Console.WriteLine(str);
            Console.WriteLine(path);
            */

            /*
            string str = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str);
            Console.WriteLine(path);
            Console.WriteLine(email);
            */

            /*
            string str1 = "this is a \n" +
                            "multi line \n" +
                            "string";

            // Verbatim string
            string str2 = @"this is a
                        multi line 
                        string";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            */
            /*
            string text1 = "This is a \"string\" in C#."; // valid
            string text2 = @"This is a "string." in C#."; // error (Use " to include " in string)
            string text3 = @"This is a \""string\" in C#."; // error (Use " to include " in string)
            string text4 = @"This is a ""string"" in C#."; // valid
            */


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NUMBERS


            //01 Byte
            /*
             * 
            byte b1 = 255;
            //byte b2 = -128; //-128 value is not between the byte range. 

            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine(Byte.MaxValue);
            Console.WriteLine(Byte.MinValue);
            Console.WriteLine(SByte.MaxValue);
            Console.WriteLine(SByte.MinValue);
            
            */

            //02 Short

            /*
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000; //35000 is gretter than short range or not betweeen the range of short data type

            ushort us1 = 65535;
            //ushort us2 = -35000;

            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);

            */

            //03 Int
            /*
             
            int i1 = -2147483648;
            int i2 = 2147483647;

            uint ui1 = 4294967295;
            // uint ui2 = -1; 

            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt32.MinValue);

            */

            //04 hexa and binary

            /*
            int hexa = 0x2F;
            int bin = 0b_0010_1111;

            Console.WriteLine(hexa);
            Console.WriteLine(bin);
            Console.WriteLine(hexa + bin);
            Console.WriteLine(hexa - bin);
            Console.WriteLine(hexa * bin);
            Console.WriteLine(hexa / bin);
            */

            //05  Long
            /*
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(Int64.MinValue); 
            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(UInt32.MinValue);
            */

            //06 Float
            /*
            float f1 = 123456.5F;
            float f2 = 1.6548237f;

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            */

            //07 Double
            /*
            double d1 = 1636541836573.9d;
            double d2 = 4873274313.43452f;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            */

            //09 Decimal
            /*
            decimal d1 = 42131242441248717240284617124.6m;
            decimal d2 = 1.632856390359923m;

            Console.WriteLine(d1);
            Console.WriteLine(d2);  
            */

            //10 Scientific Notations
            /*
            double d = 0.12e2;

            float f = 123.45e-2f;

            decimal m = 1.2e6m;

            Console.WriteLine(d);   
            Console.WriteLine(f);   
            Console.WriteLine(m);
            */

            //String 
            /*
            string ch = "P";
            string word = "Pratik";
            string text = "My name is Pratik";

            Console.WriteLine(ch);
            Console.WriteLine(word);
            Console.WriteLine(text);
            */
            /*
            char[] chars = { 'P', 'R', 'A', 'T', 'I', 'K'};

            string str1 = new string(chars);

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }

            */
            /*
            string text = "This is a \"string\" in C#."; //

            Console.WriteLine(text);
            */

            /*
            int a = 10;
            int b = 11;
            int c = 11;
            
            if (a > b && a > c)
            {
                Console.WriteLine("The gretter number is "+a);
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("The gretter number is " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The gretter number is " + c);
            }
            else
            {
                Console.WriteLine("All Are same");
            }
            */
            /*
            if (a > b)
            {
                Console.WriteLine("The gretter number is " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("The gretter number is " + b);
            }
            else if (c > a)
            {
                Console.WriteLine("The gretter number is " + c);
            }
            else
            {
                Console.WriteLine("All Are same");
            }
            */

            /*
            string text = "This is a \"5\" in C#."; 
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";

            Console.WriteLine(text);
            Console.WriteLine(str);
            Console.WriteLine(path);
            */

            /*
            string str = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str);
            Console.WriteLine(path);
            Console.WriteLine(email);
            */

            /*
            string str1 = "this is a \n" +
                            "multi line \n" +
                            "string";

            // Verbatim string
            string str2 = @"this is a
                        multi line 
                        string";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            */
            /*
            string text1 = "This is a \"string\" in C#."; // valid
            string text2 = @"This is a "string." in C#."; // error (Use " to include " in string)
            string text3 = @"This is a \""string\" in C#."; // error (Use " to include " in string)
            string text4 = @"This is a ""string"" in C#."; // valid
            */


            //DateTime

            DateTime d1 = new DateTime();

            Console.WriteLine(d1);


        }
    }
}
