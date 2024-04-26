using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string computers1(int quantity)
            {
                string result = "";
                if (quantity % 10 == 1 && quantity != 11)
                {
                    result = quantity.ToString() + " компьютер";
                }
                else if ((quantity % 10 == 2 || quantity % 10 == 3 || quantity % 10 == 4) && quantity != 12 && quantity != 13 && quantity != 14)
                {
                    result = quantity.ToString() + " компьютера";

                }
                else
                {
                    result = quantity.ToString() + " компьютеров";

                }
                return result;
            }
            string number = Console.ReadLine();
            if (Int32.TryParse(number, out int b))
            {
                Console.WriteLine(computers1(Int32.Parse(number)));
                Console.ReadLine();
            }
        }
    }
}
