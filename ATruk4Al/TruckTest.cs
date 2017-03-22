using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATruk4Al
{
    class TruckTest
    {
        static void Main(string[] args)
        {
            //StraightTrucks s1 = new StraightTrucks("mercedes", "stright", 18.36, 18.63, 18.39, 'f', 236);
            StraightTrucks s2 = new StraightTrucks();
            Console.WriteLine( s2.TimeEnlapse);
            Console.ReadLine();
        }
    }
}
