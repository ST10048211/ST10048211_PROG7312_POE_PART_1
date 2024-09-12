using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10048211_PROG7312_POE_PART_1
{
    public class SinglyLinkedList<T>
    {
        public class Node<K>
        {
            public K Data { get; set; }
            public Node<K> Next { get; set; }

            public Node(K data)
            {
                Data = data;
                Next = null;
            }

            public override string ToString()
            {
                return Data.ToString();
            }
        }

        private int _length = 0;
        private Node<T> _head;
        private Node<T> _tail;

        public int Length => _length;
        public Node<T> Head => _head;
        public Node<T> Tail => _tail;

        public void InsertIssue(T data)
        {
            var node = new Node<T>(data);
            if (_length == 0)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            _length++;
        }

        public void InsertNewIssue(T data, int idx)
        {
            var node = new Node<T>(data);
            if (idx == 0)
            {
                node.Next = _head;
                _head = node;
                if (_length == 0)
                    _tail = node;
            }
            else if (idx >= _length)
            {
                InsertIssue(data);
                return;
            }
            else
            {
                var temp = _head;
                for (int i = 0; i < idx - 1; i++)
                {
                    temp = temp.Next;
                }
                node.Next = temp.Next;
                temp.Next = node;
            }
            _length++;
        }

        public T DeleteIssue(int idx)
        {
            if (_length == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            Node<T> nodeToDelete;

            if (idx == 0)
            {
                nodeToDelete = _head;
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
            }
            else
            {
                Node<T> temp = _head;
                for (int i = 0; i < idx - 1; i++)
                {
                    temp = temp.Next;
                }

                nodeToDelete = temp.Next;
                temp.Next = nodeToDelete.Next;
                if (nodeToDelete.Next == null)
                {
                    _tail = temp; // Update the tail if the last node was deleted
                }
            }

            _length--;
            return nodeToDelete.Data;
        }

        public T GetNode(int idx)
        {
            if (idx < 0 || idx >= _length) throw new IndexOutOfRangeException();
            var temp = _head;
            for (int i = 0; i < idx; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        //public void Update(T data, int idx)
        //{
        //    var temp = _head;
        //    for (int i = 0; i < idx; i++)
        //    {
        //        temp = temp.Next;
        //    }
        //    temp.Data = data;
        //}

        public override string ToString()
        {
            if (_length == 0) return "No nodes in the list.";

            var temp = _head;
            var result = new List<string>();
            while (temp != null)
            {
                result.Add(temp.Data.ToString());
                temp = temp.Next;
            }

            return string.Join(", ", result);
        }



        // Save list data to a file
        // Save list data to a file
        public void SaveToFile(string filePath)
        {
            // Open the file in append mode
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                var current = _head;
                while (current != null)
                {
                    writer.WriteLine(current.Data.ToString());  // Write each item's data
                    current = current.Next;  // Move to the next node
                }
            }
        }
    


        // Load list data from a file
        public void LoadFromFile(string filePath, Func<string, T> parseData)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        T data = parseData(line);
                        InsertIssue(data);
                    }
                }
            }
        }

   

    }
}