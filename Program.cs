namespace GA_LinkedListDoubly_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntTest();
            StringTest();
            
        }

        public static void StringTest()
        {
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();

            // Add elements
            linkedList.Add("first");
            linkedList.Add("second");
            linkedList.Add("third");

            // Display forward and backward
            Console.WriteLine("Forward:");
            linkedList.DisplayForward();
            Console.WriteLine("Backward:");
            linkedList.DisplayBackward();

            // Remove an element
            if (linkedList.Remove("second"))
                Console.WriteLine("'second' removed");

            // Insert at end
            linkedList.InsertAtEnd("fourth");

            // Remove at index
            linkedList.RemoveAtIndex(0);

            // Display elements
            linkedList.DisplayForward();

            // Insert at front
            linkedList.InsertAtFront("new first");

            // Insert at index
            linkedList.InsertAtIndex(1, "new second");

            // Display elements
            linkedList.DisplayForward();

            // Remove by value
            linkedList.Remove("third");

            // Display elements
            linkedList.DisplayForward();

            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");
        }
        public static void IntTest()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

            // Add elements
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // Display forward and backward
            Console.WriteLine("Forward:");
            linkedList.DisplayForward();
            Console.WriteLine("Backward:");
            linkedList.DisplayBackward();

            // Remove an element
            if (linkedList.Remove(20))
                Console.WriteLine("20 removed");

            // Insert at end
            linkedList.InsertAtEnd(40);

            // Remove at index
            linkedList.RemoveAtIndex(0);

            // Display elements
            linkedList.DisplayForward();

            // Insert at front
            linkedList.InsertAtFront(10);

            // Insert at index
            linkedList.InsertAtIndex(1, 20);

            // Display elements
            linkedList.DisplayForward();

            // Remove by value
            linkedList.Remove(30);

            // Display elements
            linkedList.DisplayForward();

            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            Console.ReadLine();
        } // SampleTest


    }
}
