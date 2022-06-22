using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_StackProblem
{
    public class Queue
    {
        Linkedlist linkedList;
        public Queue()
        {
            linkedList = new Linkedlist();
        }


        public void Enqueue(Node node)
        {
            //linkedList = new Linkedlist();
            linkedList.AppendNode(node);

        }
        public void Display()
        {
            Console.WriteLine("Queue:");
            linkedList.QueueDisplay();

        }
        public void Top()
        {
            var val = linkedList.Head;
            Console.WriteLine(val.data);
        }
        public void deenque()
        {
            linkedList.DeletingNodeAtEnd();
        }
    }

}