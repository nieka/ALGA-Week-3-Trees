using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Number : Expression
    {
        private int number;
        public Number(int number)
        {
            this.number = number;
        }

        public override String ToString()
        {
            return Convert.ToString(number);
        }

        public override int evaluate()
        {
            return number;
        }
    }
}
