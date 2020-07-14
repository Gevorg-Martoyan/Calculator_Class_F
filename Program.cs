using System;

namespace Calculator_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ValidateInput obValidateInput = new ValidateInput();
            Calculate obCalculate = new Calculate();
            
            while (true)
            {
                Console.WriteLine("Enter a math expression");

               obValidateInput.inputExpression = Console.ReadLine(); // floating point number cannot read but 23 line is ok .
                //test
                //obValidateInput.inputExpression = "5+6";
                //obValidateInput.inputExpression = "-5+6-4";
                //obValidateInput.inputExpression = "5+6*2-2/2";
                //obValidateInput.inputExpression = "5+*6";
                //obValidateInput.inputExpression = "-5.1-4.1+1"; // OK

                if (obValidateInput.Validation(obValidateInput.inputExpression))
                {
                    Console.WriteLine(obCalculate.ToCalc(obValidateInput.inputExpression));
                }
                Console.WriteLine("Press 'c' key to stop calculation or any key to continue ");
                string c = Console.ReadLine();
                if (c == "c")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
