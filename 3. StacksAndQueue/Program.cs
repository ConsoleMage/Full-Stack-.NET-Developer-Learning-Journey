namespace FullStackJourney.StacksAndQueue
{

    static internal class Queue
    {

        static void Main(string[] args)
        {

            Queue<string> generalQueue = new Queue<string>();

            Queue<string> seniorsQueue = new Queue<string>();

            generalQueue.Enqueue("User 1");

            generalQueue.Enqueue("User 2");

            generalQueue.Enqueue("User 3");

            generalQueue.Enqueue("User 4");

            seniorsQueue.Enqueue("User 5");

            seniorsQueue.Enqueue("User 6");

            seniorsQueue.Enqueue("User 7");

            seniorsQueue.Enqueue("User 8");

            Console.WriteLine("Ticketing queue status...");

            while (generalQueue.Count > 0 || seniorsQueue.Count > 0)
            {

                if (generalQueue.Count > 0)

                {
                    Console.WriteLine($"Dequeued from Queue 1: {generalQueue.Dequeue()} ");
                }

                if (generalQueue.Count > 0)

                {
                    Console.WriteLine($"Dequeued from Queue 1: {generalQueue.Dequeue()} ");
                }

                if (seniorsQueue.Count > 0)

                {

                    Console.WriteLine($"Dequeued from Queue 2: {seniorsQueue.Dequeue()} ");

                }
            }

            Console.ReadLine();
        }
    }

}