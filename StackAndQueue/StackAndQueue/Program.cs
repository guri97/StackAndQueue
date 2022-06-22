namespace Day13_StackProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine("node before inserting");

            Linkedlist linked = new Linkedlist();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            //Node node4 = new Node(80);
            //linked.AddNode(node2);
            //linked.AddNode(node1);
            //linked.AddNode(node3);
            //linked.Display();
            //linked.InsertNode(node4, node3);
            //linked.Display();
            //uc3
            //linked.append(56);
            //linked.append(30);
            //linked.append(70);

            //append
            //linked.printList();

            //uc5
            //linked.AddNode(node3);//30
            //linked.AddNode(node2);//56
            //linked.AddNode(node1);//70
            //Console.WriteLine("node before deleting");
            //linked.Display();
            ////Console.Write("Delete first element");
            ////linked.removeFront();
            //Console.Write("Delete last element");
            //linked.DeletingNodeAtEnd();
            //linked.Display();
            //linked.Display();

            //*********stack**************//
            Stack stack = new Stack();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();
            //stack.Pop();
            //stack.DisplayStack();
        }
    }
}
