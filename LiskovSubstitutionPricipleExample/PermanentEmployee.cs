using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPricipleExample
{
    public class PermanentEmployee:Employee
    {
        public override double GetSalary()
        {
            return 10000;
        }
    }
}
