using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Node
    {
        public int number { get; private set; }

        public Node left;
        public Node right;

        public Node(int number)
        {
            this.number = number;
        }

        public void insert(int input){
            if (input >= number)
            {
                if (right != null)
                {
                    right.insert(input);
                }
                else
                {
                    right = new Node(input);
                }
            }
            else
            {
                if (left != null)
                {
                    left.insert(input);
                }
                else
                {
                    left = new Node(input);
                }
            }
        }

        public void print()
        {
            if (left == null && right == null)
            {
                Console.WriteLine(number);
                return;
            }

            if (left != null)
            {
                left.print();
            }
            Console.WriteLine(number);
            if (right != null)
            {
                right.print();
            }

        }

        public int dept()
        {
            int deptLeft = 1;
            int deptRight = 1;
            if (left != null)
            {
                deptLeft += left.dept();
            }
            if (right != null)
            {
                deptRight += right.dept();
            }

            if (deptLeft > deptRight)
            {
                return deptLeft;
            }
            else
            {
                return deptRight;
            }
        }
        public int count()
        {
            int count = 1;

            if (left != null)
            {
                count += left.count();
            }
            if (right != null)
            {
                count += right.count();
            }
            return count;
        }


        public Node delete(int input)
        {
            if (input == number)
            {
                // note moet verwijderd worden
                if (left == null && right == null)
                {
                    //er zijn geen chileds hieronder dus 
                    return null;
                }
                else
                {
                    if (left == null || right == null)
                    {
                        // er is maar een child dus die kan gereturnd worden.
                        if (left == null)
                        {
                            return right;
                        }
                        else
                        {
                            return left;
                        }
                    }
                    else
                    {
                        //Er zijn 2 childs die gereturnd worden.
                        Node temp = left.maxNode();
                        left = left.delete(temp.number);
                        temp.left = left;
                        temp.right = right;
                        return temp;
                    }
                }
            }
            else
            {
                if (input >= number)
                {
                    if (right != null)
                    {
                        right = right.delete(input);
                        return this;
                    }
                    else
                    {
                        return this;
                    }
                } else {
                    if (left != null)
                    {
                        left = left.delete(input);
                        return this;
                    }
                    else
                    {
                        return this;
                    }
                }
            }
        }

        public int max()
        {
            if(right != null)
            {
                return right.max();
            }
            else
            {
                return number;
            }
        }
        public int min()
        {
            if (left != null)
            {
                return left.min();
            }
            else
            {
                return number;
            }
        }
        public bool exists(int input)
        {
            if (number == input)
            {
                return true;
            }
            else
            {
                if (input >= number)
                {
                    if (right != null)
                    {
                        return right.exists(input);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (left != null)
                    {
                        return left.exists(input);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public Node maxNode()
        {
            if (right != null)
            {
                return right;
            }
            else
            {
                return this;
            }
        }

        public void printInRange(int min, int max)
        {
            if (left == null && right == null)
            {
                Console.WriteLine(number);
                return;
            }

            if (min < number)
            {
                if (left != null)
                {
                    left.printInRange(min, max);
                }
            }
            Console.WriteLine(number);
            if (number < max)
            {
                if (right != null)
                {
                    right.printInRange(min, max);
                }
            }

            
        }

    }
}
