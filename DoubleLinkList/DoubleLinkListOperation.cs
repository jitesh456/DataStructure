using System;
using System.Collections.Generic;
using System.Text;

namespace Ds.DoubleLinkList
{
    public class DoubleLinkListOperation<T>
    {
        public Node<T> head;

        /// <summary>
        /// Add data in list.
        /// </summary>
        public void add(T data)
        {
            Node<T> newNode = new Node<T>(data);
           // newNode.data = data;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                newNode.previous = temp;
                temp.next = newNode;
                
            }
        }

        /// <summary>
        /// Display All Data of List
        /// </summary>
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
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

        /// <summary>
        /// Remove Specified data from List.
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node<T> temp = head;

                //Contain Data of previous Node
                Node<T> previous = null;

                //while ( Comparer<T>.Default.Compare(temp.data,data) !=0 )
                while (!temp.data.Equals(data))
                {
                   // previous = temp;
                    temp = temp.next;
                }
                previous = temp.previous;
                Console.WriteLine("Removed:" + data);
                previous.next = temp.next;
                temp.previous = previous;
            }
        }
    }
}
