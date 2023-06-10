using System;
using System.Collections.Generic;

namespace InterviewPractice.LinkedLists
{
    public class Node
    {
        public int key;
        public int value;
        public Node next;
        public Node previous;
    }

    public class LRUCache
    {
        Dictionary<int, Node> cache;
        Node head;
        Node tail;
        int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            head = new Node();
            tail = new Node();
            head.next = tail;
            tail.previous = head;
            cache = new Dictionary<int, Node>();
        }

        public int Get(int key)
        {
            // Key doesn't exist
            if(!cache.ContainsKey(key))
            {
                return -1;
            }

            // remove the existing Node as it needs to be put first
            Node current = cache[key];
            RemoveNode(current);

            // Add the existing Node to the front
            AddNodeToHead(current);
            
            return current.value;
        }

        public void Put(int key, int value)
        {
            Node current = new Node();
            if(cache.ContainsKey(key))
            {
                cache[key].value = value;
                current = cache[key];
                RemoveNode(current);
            }
            else
            {
                current.key = key;
                current.value = value;
                cache.Add(key, current);
            }

            AddNodeToHead(current);
            
            // Remove the tail once cache reaches it's capacity
            if(cache.Count > capacity)
            {
                Node lastNode = tail.previous;
                lastNode.next = tail;
                tail.previous = lastNode.previous;

                cache.Remove(tail.key);
            }
        }

        private void RemoveNode(Node node)
        {
            node.previous.next = node.next;
            node.next.previous = node.previous;
        }

        private void AddNodeToHead(Node node)
        {
            Node firstNode = head.next;
            node.next = firstNode;
            node.previous = head;
            firstNode.previous = node;
            head.next = node;
        }
    }

    public class MRUCache
    {
        Dictionary<int, Node> cache;
        Node head;
        Node tail;
        int capacity;

        public MRUCache(int capacity)
        {
            this.capacity = capacity;
            head = new Node();
            tail = new Node();
            head.next = tail;
            tail.previous = head;
            cache = new Dictionary<int, Node>();
        }

        public int Get(int key)
        {
            // Key doesn't exist
            if(!cache.ContainsKey(key))
            {
                return -1;
            }

            // remove the existing Node as it needs to be put first
            Node current = cache[key];
            RemoveNode(current);

            // Add the existing Node to the front
            AddNodeToHead(current);
            
            return current.value;
        }

        public void Put(int key, int value)
        {
            Node current = new Node();
            if(cache.ContainsKey(key))
            {
                cache[key].value = value;
                current = cache[key];
                RemoveNode(current);
            }
            else
            {
                current.key = key;
                current.value = value;
                cache.Add(key, current);
            }

            AddNodeToHead(current);
            
            // Remove the tail once cache reaches it's capacity
            if(cache.Count > capacity)
            {
                Node lastNode = tail.previous;
                lastNode.next = tail;
                tail.previous = lastNode.previous;

                cache.Remove(tail.key);
            }
        }

        private void RemoveNode(Node node)
        {
            node.previous.next = node.next;
            node.next.previous = node.previous;
        }

        private void AddNodeToHead(Node node)
        {
            Node firstNode = head.next;
            node.next = firstNode;
            node.previous = head;
            firstNode.previous = node;
            head.next = node;
        }
    }
}