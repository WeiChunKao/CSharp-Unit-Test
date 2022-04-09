using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1單元測試基礎
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now");
            }
        }
    }
}
