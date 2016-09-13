using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class BinaryTree
    {
        public Node root;

        /**
         * Inserts a number into the tree
         */
        public void insert(int number)
        {
            if (root != null)
            {
                root.insert(number);
            }
            else
            {
                root = new Node(number);
            }
            
        }

        /**
         * Delete a number from the tree
         */
        public void delete(int number)
        {
            if (root != null)
            {
                root = root.delete(number);
            }
        }

        public bool exists(int number)
        {
            if (root != null)
            {
                return root.exists(number);
            }
            else
            {
                return false;
            }
        }

        /**
         * Returns the smallest value in the tree (or -1 if tree is empty)
         */
        public int min()
        {
            if (root != null)
            {
                return root.min();
            }
            else
            {
                return -1;
            }
        }

        /**
         * Returns the largest value in the tree (or -1 if tree is empty)
         */
        public int max()
        {
            if (root != null)
            {
                return root.max();
            }
            else
            {
                return -1;
            }
        }

        /**
         * Returns how many levels deep the deepest level in the tree is
         * (the empty tree is 0 levels deep, the tree with only one root node is 1 deep)
         * @return
         */
        public int depth()
        {
            if (root != null)
            {
                return root.dept();
            }
            else
            {
                return 0;
            }
        }

        /**
         * Returns the amount of nodes in the tree
         * @return
         */
        public int count()
        {
            if (root != null){
                return root.count();
            }
            else
            {
                return 0;
            }
        }

        public void print()
        {
            if (root != null)
            {
                root.print();
            }
            Console.ReadLine();
        }

        public void printInRange(int min, int max)
        {
            if (root != null)
            {
                root.printInRange(min, max);
            }
            Console.ReadLine();
        }
    }
}
