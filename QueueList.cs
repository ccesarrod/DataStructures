using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructres
{
    //Represents a first-in, first-out collection of objects.
    public class QueueList
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public QueueList(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int new_data)
        {
            if (rear == max - 1)
            {
                throw new InvalidOperationException("Queue Overflow");
               
            }
            else
            {
                ele[++rear] = new_data;
            }

        }

     
        public int Dequeue()
        {
            // Function to remove an item from queue.  
            // It changes front and size 
              if (front == rear + 1)
                {
                throw new InvalidOperationException("empty queue");
                }
                else
                {
                    Console.WriteLine(ele[front] + " dequeued from queue");
                    int p = ele[front++];
                    Console.WriteLine();
                    Console.WriteLine("Front item is {0}", ele[front]);
                    Console.WriteLine("Rear item is {0} ", ele[rear]);
                    return p;
                }           
        }

        public int Count => rear + 1;
    }
}
