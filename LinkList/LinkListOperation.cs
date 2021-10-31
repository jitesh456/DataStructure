using System;
using System.Collections.Generic;
using System.Text;

namespace Ds.LinkList
{
    public class LinkListOperation<T>
    {
        //Inttialized head of link list.
        public Node<T> head;

        /// <summary>
        /// Add data in list.
        /// </summary>
        public void add(T data)
        {
            Node<T> node = getNode(data);
            if (head == null)
            {
                
                head = node;
            }
            else
            {
               
                Node<T> temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                
                temp.next = node;
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
                while (temp!=null && temp.data != null)
                {
                    Console.WriteLine("Data:" + temp.data);
                    temp= temp.next;
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
                    previous = temp;
                    temp = temp.next;
                }
                Console.WriteLine("Removed:" +data);
                previous.next = temp.next;
            }
        }

        /// <summary>
        /// Insert at Start of List.
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtFirst(T data)
        {
            Node<T> node = getNode(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                head = node;
                head.next = temp;
            }
        }

        /// <summary>
        /// Insert After Specified Data.
        /// </summary>
        /// <param name="specifiedNodeData"></param>
        /// <param name="data"></param>
        public void InsertAfter(T specifiedNodeData,T data)
        {
            Node<T> node = getNode(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T>  searchedNode= head;

                //Contain Data of previous Node
                

                //while ( Comparer<T>.Default.Compare(temp.data,data) !=0 )
                while (!searchedNode.data.Equals(specifiedNodeData))
                {
                    searchedNode = searchedNode.next;
                }
                Node<T> tempNode = searchedNode.next;
                searchedNode.next = node;
                searchedNode.next.next = tempNode;
            }
        }

        /// <summary>
        /// return Node Object.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Node<T> getNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            //newNode.data = data;
            newNode.next = null;
            return newNode;
        }
    }
}
