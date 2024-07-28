using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mdk_7
{
    public class StringQueue
    {
        private Node head;
        private Node tail;

        public StringQueue()
        {
            head = null;
            tail = null;
        }

        public void Enqueue(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public string Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            string data = head.Data;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            return data;
        }

        public void PrintQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int GetTotalLength()
        {
            int totalLength = 0;
            Node current = head;
            while (current != null)
            {
                totalLength += current.Data.Length;
                current = current.Next;
            }
            return totalLength;
        }
    }
}
