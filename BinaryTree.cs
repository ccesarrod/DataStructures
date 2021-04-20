using System;
using System.Collections;

namespace datastructres
{
    public class TreeNode
    {
        private  int _data ;
        public TreeNode RightNode { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode(int new_data)
        {
            _data = new_data;          
        }

        public TreeNode Find(int new_data)
        {
            if (new_data == _data) return this;

            if (new_data <=_data && LeftNode != null) return LeftNode.Find(new_data);

            if (new_data >= _data && RightNode !=null ) return RightNode.Find(new_data);
            
            return null;
        }

        public void AddNode(int new_data)
        {
            if (new_data >= _data)
            {
                AddRightSide(new_data);
            }
            else
            {
                AddLeftSide(new_data);
            }


        }

        private void AddLeftSide(int new_data)
        {
            if (LeftNode is null)
            {
                LeftNode = new TreeNode(new_data);
            }
            else
            {
                LeftNode.AddNode(new_data);
            }
        }

        public void Display()
        {        
            Console.Write(_data + "   ");
         
        }

        public int Smallest()
        {
            if (LeftNode == null)
                return Value;
            return LeftNode.Smallest();
        }

      
        public int Value => _data;

        private void AddRightSide(int new_data)
        {
            if (RightNode is null)
                RightNode = new TreeNode(new_data);
            else
                RightNode.AddNode(new_data);
        }

    }
    public  class BinaryTree
    {
        private TreeNode _root;

        public void Insert(int new_data)
        {
            if (_root is null)
                _root = new TreeNode(new_data);
            else
            _root.AddNode(new_data);
        }

        public TreeNode Find(int new_data)
        {
            if (_root == null) return null;

            return _root.Find(new_data);
        }

        public void Delete(int data)
        {
            TreeNode current = _root;
            TreeNode parent = _root;
            Boolean isLeftChild = false;

            if (current is null) return;

            while (current != null && current.Value != data)
            {
                parent = current;

                //deleting leaf node no children
                if (data <= current.LeftNode.Value)
                {
                    current = current.LeftNode;
                    isLeftChild = true;
                }
                else
                {
                    current = current.RightNode;
                    isLeftChild = false;
                }
            }

            if (current == null)  return;

            //is leaft node
            if (current.LeftNode == null && current.RightNode == null)
            {
                if (current == _root) _root = null;

                if (isLeftChild)
                    parent.LeftNode = null;
                else
                    parent.RightNode = null;
            }

            // Node to be deleted has one child 
            else if (current.RightNode == null)
            {
                if (current == _root) _root = current.LeftNode;

                if (isLeftChild)
                    parent.LeftNode = current.LeftNode;
                else
                    parent.RightNode = current.LeftNode;
            }

            else if (current.LeftNode == null)
            {
                if (current == _root) _root = current.RightNode;

                if (isLeftChild)
                    parent.LeftNode = current.RightNode;
                else
                    parent.RightNode = current.RightNode;
            }
        }

        public int? Smallest()
        {
            if (_root != null)
                return _root.Smallest();
          return null;
        }


        public void DisplayInOrder()
        {
            TrasverseInOrder(_root);
        }
        public void DisplayPreOrder()
        {
            TrasversePreOrder(_root);
        }

        private void TrasverseInOrder(TreeNode node)
        {

            if (node != null)
            {
                TrasverseInOrder(node.LeftNode);
                node.Display();
                TrasverseInOrder(node.RightNode);
            }
        }

        private void TrasversePreOrder(TreeNode node)
        {

            if (node != null)
            {
                node.Display();
                TrasversePreOrder(node.LeftNode);               
                TrasversePreOrder(node.RightNode);
            }
        }
    }
}
