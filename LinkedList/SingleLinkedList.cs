using System;


    public class Node
    {
        public int Data;
        public Node Next;
        public  Node(int val)
        {
            Data=val;
            Next=null;
        }
    };

 public class LinkedList
{
   public Node Head;



    public void PrintList()
    {
        Node n=Head;
        while(n!=null)
        {
            Console.Write(n.Data + " ");
            n=n.Next;
        }
    }

    
}


public class Program
{
    public static void Main(String[] args)
{
    LinkedList ll=new LinkedList();
    ll.Head=new Node(5);

    Node node1=new Node(1);
    Node node2=new Node(6);
    ll.Head.Next=node1;
    node1.Next=node2;
   ll.PrintList();

}

}

//Driver Program
 