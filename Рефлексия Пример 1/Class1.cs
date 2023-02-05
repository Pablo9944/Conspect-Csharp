﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рефлексия_Пример_1
{
    public class Class1:IInterface1,IInterface2
    {
        // Поля.         
        public int myint;
        private string mystring = "Hello";

        // Конструкторы.
        public Class1() { }
        public Class1(int i)
        {
            this.myint = i;
        }

        // Свойства.
        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }

        public string MyString
        {
            get { return mystring; }
        }

        // Методы.
        public void MethodA() { }
        public void MethodB() { }

        private void MethodC(string str, string str2)
        {
            Console.WriteLine(str + str2);
        }

        public void myMethod(int p1, string p2) { }
    }
}
