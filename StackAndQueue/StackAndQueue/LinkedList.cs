using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_StackProblem
{

    public class Linkedlist
    {
        public Node Head;
        public Node Tail;
        public Linkedlist()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }

        }

        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.Write("Linked list");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
        internal void stackDisplay()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.Write("Linked list");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
        public void append(int newdata)
        {
            Node new_node = new Node(newdata);//creating new node
            if (Head == null)
            {
                Head = new Node(newdata);//if head is null we have to assign it as head
                return;
            }
            new_node.next = null;//new node next will be null
            Node last = Head;//assigined last as head
            while (last.next != null)
                last = last.next;
            last.next = new_node;//newnode appened at the last
            return;


        }
        //this is to print for the both uc2 and uc3
        public void printList()
        {
            Node tnode = Head;
            while (tnode != null)
            {
                Console.Write(tnode.data + "->");
                tnode = tnode.next;
            }
        }
        public bool Search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void removeFront()//deletingNodeAtFirst
        {
            if (this.Head != null)
            {
                Node temp = this.Head;//assiging temp variable to head 
                this.Head = this.Head.next;//assinging head to head.next
                temp = null;//make temp to null so that it can get deleted
                Console.WriteLine("deleted linkedlist:" + temp.data);
            }
            else
            {
                Console.WriteLine("linked list is empty");
            }
        }
        public void DeletingNodeAtEnd()
        {
            if (this.Head != null)
            {
                if (this.Head.next == null)
                {
                    this.Head = null;
                }
                else
                {
                    Node temp = this.Head;

                    while (temp.next.next != null)
                        temp = temp.next;
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }

        }
        public void InsertNode(Node NewNode, Node PreviousNode)
        {

            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == PreviousNode.data)
                {
                    if (temp == Tail)
                    {
                        Tail = NewNode;
                    }
                    NewNode.next = temp.next;
                    temp.next = NewNode;
                    break;

                }
                temp = temp.next;

            }
            if (temp == null)
            {
                Console.WriteLine("node not found");
            }
        }
    }

}