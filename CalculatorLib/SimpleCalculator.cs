using System;
using System.Text.RegularExpressions;

namespace CalculatorLib
{
    public class SimpleCalculator
    {
        public int Calculate(string example)
        {
            string[] numbersAndOperations = Regex
                .Replace(example, @"([\d]+)", "'$1'")
                .Split("'", StringSplitOptions.RemoveEmptyEntries);

            int result = int.Parse(numbersAndOperations[0]);
            for (int i = 1; i < numbersAndOperations.Length; i += 2)
            {
                string operation = numbersAndOperations[i].Trim();
                int number = int.Parse(numbersAndOperations[i + 1]);
                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
    }
}
