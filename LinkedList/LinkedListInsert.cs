using System;




public class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data=data;
        Next=null;
    }
};

public class LinkedList
{
    public Node Head;

    public void Push(int data)
    {
        Node newNode=new Node(data);
        newNode.Next=Head;
        Head=newNode;
    }


    public void Append(int data)
    {
        Node newNode=new Node(data);
        if(Head==null)
        {
            
            Head=newNode;
            return;
        }

        Node temp=Head;
        while(temp!=null)
        {
            temp=temp.Next;
        }

        temp.Next=newNode;
        return;


    }


     public void PrintList()
    {
        Node n=Head;
        while(n!=null)
        {
            Console.Write(n.Data + " ");
            n=n.Next;
        }
    }
};

public class Program
{
    public static void Main(String[] args)
    {
        LinkedList ll=new LinkedList();
        ll.Head=new Node(5);
       
        ll.Push(10);
        ll.Push(20);
        ll.PrintList();
    }
}