using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinkedList
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        private Node head;

        // Method to add a new node to the linked list at the end
        public void AddNext(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }


        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }


        // Method to add a new node to the linked list at the beginning

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }


        // Method to add a new node to the linked list at a specific position
        public void AddMiddle(int data, int position)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            for (int i = 0; i < position - 1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public Node GetHead()
        {
            return head;
        }

        public Node GetTail()
        {
            Node temp = head;
            if (temp == null) return null;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        // Method to delete a node at a specific index
        public void DeleteAtIndex(int index)
        {
            if (head == null) return;

            Node temp = head;
            if (index == 0)
            {
                head = temp.Next;
                return;
            }

            for (int i = 0; temp != null && i < index - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null || temp.Next == null) return;

            Node next = temp.Next.Next;
            temp.Next = next;

        }

        // Method to delete a node by value
        public void DeleteNumber(int data)
        {
            Node temp = head;
            Node prev = null;



            // Handle the case where the head node itself needs to be deleted
            while (temp != null && temp.Data == data)
            {
                head = temp.Next;
                temp = head;
            }

            // Traverse the list and delete nodes with the specified data
            while (temp != null)
            {
                // If the current node's data matches the target data
                if (temp.Data == data)
                {
                    prev.Next = temp.Next;
                }
                else
                {
                    prev = temp;
                }
                temp = temp.Next;
            }
        }

        // Method to get the position of a node by value
        public int GetPosition(int data)
        {
            Node temp = head;
            int position = 0;

            while (temp != null)
            {
                if (temp.Data == data)
                {
                    return position;
                }
                position++;
                temp = temp.Next;
            }

            return -1; // Return -1 if the data is not found
        }

        // Function to remove duplicates without extra space
        public void RemoveDuplicates()
        {
            Node current = head;

            while (current != null && current.next != null)
            {
                Node runner = current;

                // Check for any duplicates in subsequent nodes
                while (runner.next != null)
                {
                    if (runner.next.data == current.data)
                    {
                        // Remove the duplicate node
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }

                current = current.next;
            }
        }

        public void BubbleSort()
        {
            if (head == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = head;
                Node prev = null;
                Node next = head.Next;

                while (next != null)
                {
                    if (current.Data > next.Data)
                    {
                        // Swap values
                        (current.Data, next.Data) = (next.Data, current.Data);
                        swapped = true;
                    }

                    prev = current;
                    current = next;
                    next = next.Next;
                }
            } while (swapped);
        }
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            list.AddNext(0);
            list.AddNext(1);
            list.AddNext(2);
            list.AddNext(3);
            list.AddNext(4);
            list.Display();

            list.AddMiddle(4, 2);
            list.Display();

            list.Reverse();

            list.Display();
            int result = list.GetPosition(4);
            Console.WriteLine("The number 4 is present at " + result);
            
            //Delete data at specific index
            list.DeleteAtIndex(2);
            list.Display();

            //Delete the data
            list.DeleteNumber(1);
            list.Display();


            Console.WriteLine("Head: " + list.GetHead()?.Data);
            Console.WriteLine("Tail: " + list.GetTail()?.Data);
            list.Display();

            list.BubbleSort();
            Console.WriteLine("The Sorted LinkedList");
            list.Display();
        }
    }
}


