namespace datastructres
{
    public class Node<T>
    {
        public  T data;
        public Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }

    public class SingleLinkedList<T>
    {
        public Node<T> headNode;
        public Node<T> currentNode;
        private int _count;

        public SingleLinkedList()
            {
            currentNode = headNode;
            _count = 0;
            }
      public Node<T> GetNext()
        {
            if (currentNode ==null  || currentNode.next == null) return null;
            var tempNode = currentNode.next;

            currentNode = tempNode;

            return currentNode;

        }
         public void AddNode(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);

            if (headNode == null)
            {
                headNode = new_node;
                currentNode = headNode;
                _count++;
                return;
            }

            
            while (currentNode.next != null)
            {
                 GetNext();

            }

            currentNode.next = new_node;
            ++_count;
        }
       public  void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = headNode;
            headNode = new_node;
            
            _count++;
        }

        public void InsertBack(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);

            if (headNode == null)
            {
                headNode = new_node;
                currentNode = headNode;
                _count++;
                return;
            }
           
                while (currentNode.next != null)
                {
                    currentNode = GetNext();
                }

                currentNode.next = new_node;
            currentNode = new_node;
                _count++;
        }

        public void Delete(T delete_data)
        {
            currentNode = headNode;
            Node<T> previousNode = null;
           
            if ( headNode.data.Equals(delete_data))
            {
                currentNode = headNode.next;
                headNode = currentNode;
                _count--;
                return;
            }
            while (currentNode != null && !currentNode.data.Equals(delete_data))
            {      
                
                   previousNode = currentNode;                     
                
                  currentNode = GetNext();
            }

            if (currentNode == null) return;

            previousNode.next = currentNode.next;
            currentNode = previousNode;
            _count--;
        }

        public Node<T> FindNode(T data)
        {
            var tempNode = headNode;

            while ( tempNode.next != null && !tempNode.data.Equals(data))
            {
                tempNode = tempNode.next;
            }
            return tempNode.data.Equals(data)? tempNode: null;
        }

        public void ReverseLinkList()
        {
            Node<T> prev = null;
            currentNode = headNode;
            Node<T> temp = null;

            while(currentNode.next != null)
            {
                prev = currentNode;
                temp = currentNode.next;
                prev.next = temp.next;
                temp.next = prev;
                currentNode = temp.next;                
                

            }
            headNode = temp;
        
        }

        public int Lenght => _count;
    }
}
