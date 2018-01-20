using System;
using System.Collections.Generic;

namespace HackerRankCode
{
    class RemoveDuplicateLinkList
    {
        //Remove duplicates from a Linked List and return the updated linked list
        public Node removeDuplicates(Node head)
        {
            //Store data of each node in a set, so that if the same number comes again, we do not add it.
            HashSet<int> set = new HashSet<int>();
            Node temp = head;
            Node prev = null;
            while (temp != null)
            {
                if (!set.Contains(temp.data))
                {
                    set.Add(temp.data);
                    prev = temp;
                }
                else
                    prev.next = temp.next; //If duplicate comes, remove that node by linking the next pointer of previous node to the next of temporary node. In this way, the temp node is bypassed.
                temp = temp.next;
            }
            return head;
        }

        public Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
