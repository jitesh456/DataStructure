using Ds.DoubleLinkList;
using Ds.ExceptionHsndling;
using Ds.LinkList;
using Ds.LinkListStack;
using System;

namespace Ds
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack<int> linkedListStack = new LinkedListStack<int>();
            linkedListStack.display();
            linkedListStack.push(10);
            linkedListStack.push(20);
            linkedListStack.display();
            linkedListStack.pop();
            linkedListStack.display();
            Console.ReadKey();
        }
    }
}
