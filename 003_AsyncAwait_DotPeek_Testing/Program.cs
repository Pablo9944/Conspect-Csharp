using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_AsyncAwait_DotPeek_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            MyClass my = new MyClass();
            my.OperationAsync();

            // Delay
            Console.ReadKey();
        }
    }
    internal class MyClass
    {
        public void Operation()
        {
            Console.WriteLine("Operation ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }

        public void OperationAsync()
        {
            AsyncStateMachine stateMachine = new AsyncStateMachine();
            stateMachine.outer = this;
            stateMachine.builder = AsyncVoidMethodBuilder.Create();
            stateMachine.state = -1;
            stateMachine.builder.Start(ref stateMachine);
        }

        private struct AsyncStateMachine : IAsyncStateMachine
        {
            public MyClass outer;
            public AsyncVoidMethodBuilder builder;
            public int state;

            int counterCallMoveNext;

            // builder.Start первый раз вызывает метод MoveNext - Синхронно, 
            // а второй раз builder.AwaitOnCompleted вызывает его - Асинхронно, только после того как отработает задача.
            void IAsyncStateMachine.MoveNext()
            {
                Console.WriteLine("\nMетод MoveNext вызван {0}-й раз в потоке {1}",
                    ++counterCallMoveNext, Thread.CurrentThread.ManagedThreadId);

                if (state == -1)
                {
                    Console.WriteLine("OperationAsync (Part I) ThreadID {0}\n", Thread.CurrentThread.ManagedThreadId);

                    Task task = new Task(outer.Operation);
                    task.Start();

                    state = 0;
                    TaskAwaiter awaiter = task.GetAwaiter();
                    builder.AwaitOnCompleted(ref awaiter, ref this); // Закомментировать.
                    return; // Не позволяет продолжиться методу (при первом вызове).
                }

                // Срабатывает только при втором вызове метода MoveNext.
                Console.WriteLine("OperationAsync (Part II) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            }

            // builder.AwaitOnCompleted вызывает данный метод синхронно, во время выполнения задачи.
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                Console.WriteLine("\nМетод SetStateMachine ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("stateMachine.GetHashCode {0}", stateMachine.GetHashCode());
                Console.WriteLine("this.GetHashCode         {0}\n", this.GetHashCode());

                builder.SetStateMachine(stateMachine);
            }
        }
    }
}
