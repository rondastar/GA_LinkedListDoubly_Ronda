namespace GA_LinkedListDoubly_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleTest();
        }

        public static void ExampleTest()
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
    
            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            Console.ReadLine();
        } // SampleTest
    }
}
