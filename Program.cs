using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter math expression of the form 'number*number*number...':");
            string input = Console.ReadLine();

            try
            {
                int result = CalculateExpression(input);
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: wrong formate of input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int CalculateExpression(string input)
        {
            string[] tokens = input.Split('*');
            int result = 1;

            foreach (string token in tokens)
            {
                if ( (int.TryParse(token, out int number)))
                    {
                    result *= number;
                }
                else
                {
                    throw new FormatException();
                }
                }

            return result;
            }
        }
    }

