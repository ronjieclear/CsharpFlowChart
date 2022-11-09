using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cp = 0;
            double sp = 0;
            double profit = 0;  
            double loss=0;
            Console.Write("Enter Cost Price: ");
            cp = Double.Parse(Console.ReadLine());
            Console.Write("Enter Selling Price: ");
            sp = Double.Parse(Console.ReadLine());
            if (sp > cp)
            {
                profit = sp-cp;
                Console.WriteLine($"Profit: {profit}");
            }
            else
            {
                loss= cp - sp;
                Console.WriteLine($"Loss: {loss}");
            }
            Console.ReadLine();
        }
    }
}
