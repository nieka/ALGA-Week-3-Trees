using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Operand : Expression
    {
        private char operand;
        private Expression left;
        private Expression right;
        public Operand(char operand, Expression left, Expression right)
        {
            this.operand = operand;
            this.left = left;
            this.right = right;
        }

        public override int evaluate()
        {
            int leftwaarde = left.evaluate();
            int rigthwaarde = right.evaluate();
            switch (operand)
            {
                case '+':
                    return leftwaarde + rigthwaarde;
                case '-':
                    return leftwaarde - rigthwaarde;
                case '*':
                    return leftwaarde * rigthwaarde;
                case '/':
                    return leftwaarde / rigthwaarde;
                default:
                    throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            string output = "(";

            output += left.ToString();
            output += operand;
            output += right.ToString();


            output += ")";

            return output;
        }
    }
}
