using Ds.LinkList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ds.LinkListQueue
{
    public class LinkedListQueue<T>
    {
        Node<T> head;
        public LinkedListQueue()
        {
            this.head = null;
        }

        public void EnQueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                this.head.next = newNode;
                Console.WriteLine(data + " is added into Queue");
            }
        }

        public void DeQueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine(data + "is removed from Queue");
                this.head = this.head.next;
            }
        }

        /// <summary>
        /// Display All Data of List
        /// </summary>
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Node<T> temp = head;
                while (temp != null && temp.data != null)
                {
                    Console.WriteLine("Data:" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
