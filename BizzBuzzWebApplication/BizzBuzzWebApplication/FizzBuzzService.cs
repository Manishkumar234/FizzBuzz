using System;
using System.Collections.Generic;

public class FizzBuzzService
{
    public string ProcessValue(string input, out List<string> operations)
    {
        operations = new List<string>();
        if (int.TryParse(input, out int number))
        {
            string result = string.Empty;
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }
            if (string.IsNullOrEmpty(result))
            {
                operations.Add($"Divided {number} by 3");
                operations.Add($"Divided {number} by 5");
                return number.ToString();
            }
            return result;
        }
        else
        {
            return "Invalid item";
        }
    }
}
