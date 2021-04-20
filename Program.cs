using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructres
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(52);
            tree.Insert(65);
            tree.Insert(33);
            tree.Insert(39);
            tree.Insert(34);
            tree.Insert(48);
            tree.Insert(25);
            tree.Insert(12);
            tree.Insert(27);
            tree.Insert(60);
            tree.Insert(78);
            tree.Insert(90);
            tree.Insert(72);
            tree.Insert(70);

          //  tree.DisplayInOrder();
            tree.DisplayPreOrder();
        } 
    
    }
}
