using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisoj
{
    public class Lengthchk
    {
        public void Comparison()
        {
            Console.WriteLine("Enter the line point x1: ");
            //Console.WriteLine("Enter the line point x2: ");
            //Console.WriteLine("Enter the line point y1: ");
            //Console.WriteLine("Enter the line point y2: ");

            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the line point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            var Length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(Length1);
        }

    }
}
    