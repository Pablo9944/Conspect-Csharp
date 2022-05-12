using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Полиморфизм__virtual_overide_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hiding

            //A a = new A();
            //a.Display();

            //B b = new B();  
            //b.Display();

            //C c = new C();
            //c.Display();

            //a.Display();    // метод класса A
            //b.Display();    // метод класса B
            //((A)b).Display();   // метод класса B

            //c.Display();    // метод класса C
            //((A)c).Display();   // метод класса B
            //((B)c).Display();	// метод класса B

            #endregion

            #region Индексаторы
            var array = new Book[]
            {
                new Book
                {
                  Name = "Мастер и Маргарита",
                  Author = "М.А. Булгаков"
                },
                new Book
                {
                  Name = "Отцы и дети",
                  Author = "И.С. Тургенев"
                },
              };
            BookCollection collection = new BookCollection(array);

            Book book = collection[1];
            #endregion

            #region Переопределение свойств
            //Citizen c = new Citizen { Age = 5 };
            //c.SayYourAge();

            //CivilServant cs = new CivilServant { Age = 18 };
            //cs.SayYourAge();

            //President p = new President { Age = 17 };
            //p.SayYourAge();
            #endregion
        }
    }

    #region Переопределение метода virtual override
    
    //class BaseClass
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }
    //}

    #endregion

    #region Переопределение свойств

    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public  void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
      

    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    #endregion


    //class BaseClass
    //{
    //    public virtual int Counter
    //    {
    //        get; set;

    //    }
    //    public void Print ()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }

    //}

    //class DerivedClass : BaseClass
    //{
    //    public override int Counter
    //    {
    //        get
    //        {
    //            return Counter;
    //        }
    //        set
    //        {
    //            if (Counter > 0 )
    //            {
    //                Counter = value;
    //            }
    //        }
    //    }



    //}


    #region Base для метода

    //class BaseClass
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public override void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }

    //}
    #endregion


    #region sealed При переопределении метода можно запрещать дальнейшее его переопределение. Для этого при объявлении нужно добавлять модификатор sealed:
    //class BaseClasss
    //{
    //    public virtual void Method()
    //    {
    //    }
    //}

    //class InheritedClass : BaseClasss
    //{
    //    public override sealed void Method()
    //    {
    //    }
    //}
    #endregion


    #region hiding (new вместо override) Для сокрытия базового метода, в производном классе следует использовать ключевое слово new (вместо override):

    //class BaseClasss
    //{
    //    public virtual void Method()
    //    {
    //    }
    //}

    //class InheritedClass : BaseClasss
    //{
    //    public new void Method()
    //    {
    //    }
    //}

    #endregion


    #region Индексаторы (Могут не иметь блока set
    //class Book
    //{
    //    public string Name;
    //    public string Author;
    //}

    //// Класс для объекта “Коллекция книг”
    //class BookCollection
    //{
    //    // Закрытое поле, хранящее книги в виде массива
    //    private Book[] collection;

    //    // Конструктор с добавлением массива книг
    //    public BookCollection(Book[] collection)
    //    {
    //        this.collection = collection;
    //    }

    //    // Индексатор по массиву
    //    public Book this[int index]
    //    {
    //        get
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                return collection[index];
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }

    //        private set
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                collection[index] = value;
    //            }
    //        }
    //    }
    //}
    //class IndexingClass
    //{
    //    private int[] array;

    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            array[index] = value;
    //        }
    //    }
    //    public IndexingClass(int[] array)
    //    {
    //        this.array = array;
    //    }
    //}

    #endregion 

    

}
