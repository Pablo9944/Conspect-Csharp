﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Async_await_под_DotPeek
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
    class MyClass
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
            AsyncStateMachine stateMachine;
            stateMachine.outer = this;
            stateMachine.builder = AsyncVoidMethodBuilder.Create();
            stateMachine.builder.Start(ref stateMachine);
        }

        struct AsyncStateMachine : IAsyncStateMachine
        {
            public MyClass outer;
            public AsyncVoidMethodBuilder builder;

            void IAsyncStateMachine.MoveNext()
            {
                Task task = new Task(outer.Operation);
                task.Start();
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                /* Данный метод не играет важной роли в этом примере. */
                throw new NotImplementedException();
            }
        }
    }
