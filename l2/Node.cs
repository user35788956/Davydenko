using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2
{
    internal class Node
    {
        public string Data;
        public Node Next;

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public LinkedList(string data)
        {
            head = new Node(data);
        }

        public LinkedList(string[] data)
        {
            head = new Node(data[0]);

            Node current = head;

            for (int i = 1; i < data.Length; i++)
            {
                current.Next = new Node(data[i]);
                current = current.Next;
            }
        }

        public void Add(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Remove(string data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    if (current.Next.Data == data)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }

                    current = current.Next;
                }
            }
        }
        public void RemoveEnd()
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;

                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
            }
        }

        public void RemoveAfter(string data)
        {
            if (head == null)
            {
                return;
            }

            Node current = head;

            while (current != null && current.Data != data)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return;
            }

            current.Next = null;
        }

        public void RemoveAll()
        {
            head = null;
        }

        public Node Head
        {
            get { return head; }
            set { head = value; }
        }

        public static LinkedList operator +(LinkedList list, string data)
        {
            list.Add(data);
            return list;
        }

        public static LinkedList operator -(LinkedList list, string data)
        {
            list.Remove(data);
            return list;
        }
    }
}
