using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _007._1_AsyncAwait_ReturnValue_DotPeek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass my = new MyClass();
            Task<int> task = my.OperationAsync();
  
            task.ContinueWith(t => Console.WriteLine("Результат : {0}", t.Result));

            // Delay
            Console.ReadKey();
        }
    }
    class MyClass
    {
        int Operation()
        {
            Thread.Sleep(2000);
            return 2 + 2;
        }

        public Task<int> OperationAsync()
        {
            AsyncStateMachine stateMachine;
            stateMachine.outer = this;
            stateMachine.builder = AsyncTaskMethodBuilder<int>.Create();
            stateMachine.state = -1;
            stateMachine.builder.Start(ref stateMachine);

            return stateMachine.builder.Task;
        }

        struct AsyncStateMachine : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder<int> builder;
            public MyClass outer;
            public int state;

            private TaskAwaiter<int> awaiter;

            void IAsyncStateMachine.MoveNext()
            {
                if (state == -1)
                {
                    Func<int> function = outer.Operation;
                    Task<int> task = Task<int>.Factory.StartNew(function);
                    awaiter = task.GetAwaiter();

                    state = 0;

                    builder.AwaitOnCompleted(ref awaiter, ref this);
                    return;
                }

                int result = awaiter.GetResult();
                builder.SetResult(result);
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                builder.SetStateMachine(stateMachine);
            }
        }
    }
}
