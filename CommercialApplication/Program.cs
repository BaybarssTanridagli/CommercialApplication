using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double purchase, gainRate, sell;
            Console.WriteLine("Please Enter The Purchase Rate: ");
            purchase=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Gain Rate: ");
            gainRate=Convert.ToDouble(Console.ReadLine());
            sell = purchase + (purchase * gainRate / 100);
            Console.WriteLine("Price : {0}", sell);
            Console.ReadKey();
        }
    }
}
