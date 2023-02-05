using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _011_TPL_TaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            List<Task> tasks = new List<Task>();
            TaskScheduler scheduler = new DelayTaskScheduler();
            TaskFactory factory = new TaskFactory(scheduler);
            tasks.Add(factory.StartNew(MyTask1));
            tasks.Add(factory.StartNew(MyTask2));

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("\nВсе задачи завершены.");
        }
        static void MyTask1()
        {
            Console.WriteLine("MyTask1 ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }
        }

        static void MyTask2()
        {
            Console.WriteLine("MyTask2 ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("- ");
            }
        }
    }
    class DelayTaskScheduler : TaskScheduler
    {
        Queue<Task> queue = new Queue<Task>();

        protected override void QueueTask(Task task) // Вызывается 1-ым.
        {
            Console.WriteLine("QueueTask");
            queue.Enqueue(task);

            WaitCallback callback = (object state) => base.TryExecuteTask(queue.Dequeue());
            ThreadPool.QueueUserWorkItem(callback, null);  // Асинхронный вызов задач.
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) // Вызывается 2-ым.
        {
            Console.WriteLine("TryExecuteTaskInline");
            //base.TryExecuteTask(queue.Dequeue());
            return false; // return true; - Будет исключение.
        }

        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return queue;
        }
    }
}
