using System;
using System.Data;

namespace Calculator_class
{
    class Calculate
    {
        
        public DataTable ForCalc = new DataTable();
          
        public double ToCalc(string Expression)
        {
            
            return Convert.ToDouble(ForCalc.Compute(Expression, string.Empty));
        }

    }
}