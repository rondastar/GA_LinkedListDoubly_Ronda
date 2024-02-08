using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedListDoubly_Ronda
{
    internal class DoublyLinkedList<T>
    {
        // Private fields to track the head, tail, and count of elements.
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        // Public property to access the count of elements.
        public int Count
        {
            get { return count; }
        }

        // Constructor to initialize an empty doubly linked list.
        public DoublyLinkedList()
        {
            // Initially, both head and tail are null, and the count is 0.
            head = null;
            tail = null;
            count = 0;
        }


        // Nested class LinkedListNode representing elements in the doubly linked list.
        class LinkedListNode<T>
        {
            public T Value { get; set; }                    // Data stored in the node.
            public LinkedListNode<T> Next { get; set; }     // Reference to the next node.
            public LinkedListNode<T> Previous { get; set; } // Reference to the previous node.

            public LinkedListNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
        
        // Add an element to the end of the list.
        public void Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        // Inserts a new node at the front of the linked list
        public void InsertAtFront(T value)
        {
            // Create a new node with the given value.
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (head == null)
            {
                // If the list is empty, set both head and tail to the new node.
                head = newNode;
                tail = newNode;
            }
            else
            {
                // If the list is not empty, insert the new node at the front.
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            // Increment the count to reflect the addition of a new element to the list.
            count++;
        } // InsertAtFront

        // Inserts a new node at the tail
        // ======================= TEST THIS ONE =============================
        internal void InsertAtEnd(T value)
        {
            // Create a new node with the given value.
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            // Set the "Previous" reference of the new node to the current tail.
            newNode.Previous = tail;

            // Set the "Next" reference of the current tail to the new node.
            tail.Next = newNode;

            // Update the tail to be the new node, making it the new last node in the list.
            tail = newNode;
        } // InsertAtEnd

        // Inserts a new node at the specified index
        // ======================= TEST THIS ONE =============================

        public void InsertAtIndex(int index, T value)
        {
            // Check if the provided index is out of range.
            ValidateRange(index);

            // Create a new node with the given value.
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (index == 0)
            {
                // Insert at the beginning (index 0).
                // Set the "Next" reference of the new node to the current head.
                newNode.Next = head;

                if (head != null)
                {
                    // If the list was not empty, set the "Previous" reference of the current head to the new node.
                    head.Previous = newNode;
                }

                // Update the head to be the new node, making it the new first node in the list.
                head = newNode;

                if (count == 0)
                {
                    // If the list was initially empty, set the tail to the new node as well.
                    tail = newNode;
                }
            }
            else if (index == count)
            {
                // Insert at the end (index count).
                // Set the "Previous" reference of the new node to the current tail.
                newNode.Previous = tail;

                // Set the "Next" reference of the current tail to the new node.
                tail.Next = newNode;

                // Update the tail to be the new node, making it the new last node in the list.
                tail = newNode;
            }
            else
            {
                // Insert at a middle index.
                // Initialize a current node to traverse the list to the node before the desired index.
                LinkedListNode<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                // Update references to insert the new node in the middle.
                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next.Previous = newNode;
                current.Next = newNode;
            }

            // Increment the count to reflect the addition of a new element to the list.
            count++;
        } // InsertAtIndex

        // Removes node at the specified index
        public T RemoveAtIndex(int index)
        {
            // Check if the provided index is out of range.
            ValidateRange(index);

            // Temporary placeholder for data that is being removed
            T temp = default(T);

            if (index == 0)
            {
                // assign value to be removed from head node to temp
                temp = head.Value;

                // If the next node is empty, reset head and tail to null
                if (head.Next == null)
                {
                    head = null;
                    tail = null;
                }
                if (head.Next != null)
                {
                    // If the next node is not null, update references so it is the head
                    head = head.Next;
                    head.Previous = null;
                }
            }
            else if (index == count)
            {
                // assign value to be removed from tail node to temp
                temp = tail.Value;

                // Update the references so that the node before the tail is the new tail.
                tail.Previous = tail;
                tail.Next = null;
            }
            else
            {
                // Insert at a middle index.
                // Initialize a current node to traverse the list to the node before the desired index.
                LinkedListNode<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                // Assign value to be removed from next node to temp
                temp = current.Next.Value;

                // Update references to remove the node at the index.
                current.Next.Previous = current;
                current.Next = current.Next.Next;
            }

            // Decrement the count
            count--;

            return temp;
        } // RemoveAtIndex

        // Removes the node at the head
        public T RemoveAtFront()
        {
            // If head is already null, return default
            if(head == null)
            {
                // return default if no value is removed
                return default(T);
            }

            // assign value to be removed from head node to temporary variable
            T temp = head.Value;

            if(head.Next == null)
            // If the next node is empty, reset head and tail to null
            if (head.Next == null)
            {
                head = null;
                tail = null;
            }
            if (head.Next != null)
            {
                // If the next node is not null, update references so it is the head
                head = head.Next;
                head.Previous = null;
            }

            // decrement the count
            count--;
             // return the value that was removed
            return temp;
        }

        public T RemoveAtEnd()
        {
            // If tail is already null, return default
            if (tail == null)
            {
                // return default if no value is removed
                return default(T);
            }

            // Assign value to be removed from head node to temporary variable
            T temp = tail.Value;

            // Update references so that the node before the tail is the new tail
            tail = tail.Previous;
            tail.Next = null;

            // decrement the count
            count--;
            // return the value that was removed
            return temp;
        } // RemoveAtEnd

        // Display forward, from head to tail
        public void DisplayForward()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        } // DisplayForward

        // Display backward, from tail to head
        public void DisplayBackward()
        {
            LinkedListNode<T> current = tail;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Previous;
            }
            Console.WriteLine("null");
        } // DisplayBackward

        // Remove a node by value
        public bool Remove(T value)
        {
            LinkedListNode<T> current = head;

            // transverse the list to find the node
            while (current != null)
            {
                // updates references of neighboring nodes when found
                if (current.Value.Equals(value))
                {
                    if (current == head) head = head.Next;
                    if (current == tail) tail = tail.Previous;
                    if (current.Next != null) current.Next.Previous = current.Previous;
                    if (current.Previous != null) current.Previous.Next = current.Next;
                    
                    // decrease the count
                    count--;
                    return true;
                }

                // iterate to next node
                current = current.Next;
            }

            return false;
        } // Remove

        // Indexer Override - accesses elements by index
        public T this[int index]
        {
            get
            {
                // Validate the index
                ValidateRange(index);

                // Transverse to the node at the specified index
                LinkedListNode<T> current = head;
                for (int i = 0; i < index; i++)
                    current = current.Next;

                return current.Value;
            }
        } // Indexer Override

        // clears the linked list by resetting the head and tail references to null and count to zero
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        } // Clear

        // checks whether index is within the range of the linked list
        public void ValidateRange(int index)
        {
            if (index < 0 || index > count)
            {
                // Throw an exception if the index is invalid.
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
        } // ValidateRange
    }
}
