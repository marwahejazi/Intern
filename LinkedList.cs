using System;
using System.Collections;
namespace AsalIntern2
{ 
    public class Node
    {
        public int data;
        public Node next;
        public Node head;
        public Node(int d)
        {
            next = null;
            data = d;
        }
    }
        public class LinkedList
    {
        Node node;
        public Node head;
        public LinkedList InsertToList(LinkedList list, Node node)
            {
                if (node.head == null)
                {
                    node.head = node;
                }
                else
                {
                    Node last = node.head;
                    while (last.next != null)
                    {
                        last = last.next;
                    }
                    last.next = node;
                }
                return list;
            }  
        /*void delete(int Key)
        {
            Node temp = head;
            Node prev = null;
            if (temp !=null && temp.data == Key)
            {
                head = temp.next;
                return;
            }
            while (temp !=null && temp.data != Key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }*/

        public LinkedList Reverse(LinkedList list)
        {
            Node prev = null , next=null;
            Node current = node.head;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }// wrong?
            node.head = prev;
            return list;
        }
        //Delete within a known key
        public void Delete(int key)
        {
            node = head;
            Node current = head;
            Node prev = null;
            while(node != null)
            {
                current = node;
                if (node.data == key)
                {
                    prev.next = current.next;
                }
                else
                {
                    head = head.next;
                }
                break;
            }
        }
        //Sort
        public  Node Sort(int count)
        {
            
            //find min node
            //insert it to a new sorted list and repeat..
            Node current = head;
            Node prev = current;
            Node min = current;
            Node minPrev = min;
            Node SortHead = null;
            Node SortTail = SortHead;
            for(int i=0; i<count; i++)
            {
                current = head;
                min = current;
                minPrev = min;
                while (current != null)
                {
                    if(current.data < min.data)
                    {
                        min = current;
                        minPrev = prev;
                    }
                    prev = current;
                    current = current.next;
                }
                if (min == head)
                {
                    head = head.next;
                }
                else if (min.next == null)
                {
                    minPrev.next = minPrev.next.next;
                }
                if(SortHead != null)
                {
                    SortTail.next = min;
                    SortTail = SortTail.next;
                }
                else
                {
                    SortHead = min;
                    SortTail = SortHead;
                }
            }
            return SortHead;
        }
        //search 
        public bool Search(Node head, int x)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == x)
                    return true;
                current = current.next;
            }
            return false;
        }
        public void printAllNode()
        {
            Node temp = head;
            
            // if the list is empty
            if(head == null)
            { 
                Console.WriteLine("Nothing to print in the list");
            }
            else
            {
                while (temp != null) 
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        
    }
        }
    

