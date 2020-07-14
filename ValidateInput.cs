using System;


namespace Calculator_class
{
    class ValidateInput
    {
        public String inputExpression;
        public bool Validation(string inputExpression)
        {
            if (!(char.IsDigit(inputExpression[0]) || (Convert.ToChar(inputExpression[0]) == '-'))|| !(char.IsDigit(inputExpression[inputExpression.Length-1]) ))
            {
                Console.WriteLine("Wrong math expression!");
                return false;
            }

            int i = 1;
            while (i < inputExpression.Length - 1)
            {
                
                if (!(  char.IsDigit(inputExpression[i]) || Convert.ToChar(inputExpression[i]) == '.'
                    || Convert.ToChar(inputExpression[i]) == '+' || Convert.ToChar(inputExpression[i]) == '-'
                    || Convert.ToChar(inputExpression[i]) == '*' || Convert.ToChar(inputExpression[i]) == '/'))
                {
                    Console.WriteLine("Wrong math expression!");
                    return false;
                }
                else if (!char.IsDigit(inputExpression[i]) && !char.IsDigit(inputExpression[i - 1]))
                {
                    Console.WriteLine("Wrong math expression!");
                    return false;
                }
                else
                    i++;

            }
            return true;

        }
    }
}