using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            StackAndQueue list = new StackAndQueue();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();

        }
    }
}
