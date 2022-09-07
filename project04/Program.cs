using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 10;
            Console.WriteLine("a=b for addition");
            Console.WriteLine("a-b for substration");
            Console.Writeline(a*b  for multiply");
            Console.WriteLinefor division");
            Console.WriteLine("select your option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("you have selected addition");
                    break;
                    case 2:
                    Console.WriteLine("you have selected substraction");
                    break;
                case 3:
                    Console.WriteLine("you have selected multiply");
                    break;
                case 4:
                    Console.WriteLine("you have selected division");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;


            }
            }
          

  

        }
    }


