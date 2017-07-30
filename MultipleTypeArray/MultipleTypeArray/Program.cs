using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] Array1 = new object[4];
            Array1[0] = 100;
            Array1[1] = System.DateTime.Now;
            Array1[2] = "somestring";
            Array1[3] = 23.34;

            int id = int.Parse(Convert.ToString(Array1[0]));
            DateTime joining = DateTime.Parse(Convert.ToString(Array1[1]));
            Console.WriteLine(id);
            Console.WriteLine(joining);
            Console.ReadLine();



        }
    }
}
