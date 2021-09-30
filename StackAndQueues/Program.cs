using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            StackAndQueue list = new StackAndQueue();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Peek(); 
            list.Pop();
            list.IsEmpty();
            list.Display();

        }
    }
}
