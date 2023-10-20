using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Days
    {
        sun,
        mon,
        tue = 15,
        wed,
        thu,
        fri,
        sat

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = (int)Days.fri;
            Console.WriteLine("friday = {0}" , x);

            foreach( string s in Days.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
