using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPricipleExample
{
    public class ContractEmployee:Employee
    {
        public override double GetSalary()
        {
            return 15000;
        }
    }
}
