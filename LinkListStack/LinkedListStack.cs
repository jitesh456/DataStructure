
using Ds.LinkList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ds.LinkListStack
{
    public class LinkedListStack<T>
    {
        Node<T> top;

        public LinkedListStack()
        {
            this.top = null;
        }

        public void push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            this.top = newNode;
            Console.WriteLine("{0} push to stack", value);
        }

        public void display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            
        }
        public void pick()
        {

            if (this.top != null)
            {
                Console.WriteLine(this.top.data);
            }
            else 
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else 
            {
                Console.WriteLine("removed : "+this.top.data);
                this.top = this.top.next;
            }
        }

    }
}
