using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new { id=101, name = "Ram", addr = "Puna", email = "abd123@gmail.com", contNo = 9087657478, sal = 500000.500, AdharNo = 534342347574};
            Console.WriteLine(emp.GetType().ToString());

            Console.WriteLine(emp.id+" "+emp.name+" " + emp.addr + " " + emp.email + " " + emp.contNo + " " + emp.sal + " " + emp.AdharNo);


            var stu = new { Roll_No = 1, name = "mayur",contact_no = 8989898989, addr = "yeola", branch = "computer"};
            Console.WriteLine(emp.GetType().ToString());
        }
    }
}
