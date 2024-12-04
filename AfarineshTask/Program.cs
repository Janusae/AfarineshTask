


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfarineshTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers : ");
            List<string> inputs = new List<string>();
            while (true)
            {
                var input =  Console.ReadLine();
                if (input.ToUpper() == "END")
                {
                    break;
                }
                inputs.Add(input);
            }
            var biggest = 0;
            for (int i = 1; i < inputs.Count; i++)
            {
                var text = inputs[i];
                var number = text.Split(',');
                var distance = Convert.ToInt32(number[1]) - Convert.ToInt32(number[0]);
                if (biggest < distance)
                {
                    biggest = distance; 
                }

            }
            Console.WriteLine(biggest);


        }
    }
}
