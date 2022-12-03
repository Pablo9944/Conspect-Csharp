using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{

    #region Assert

    //Класс Assert содержит набор статических методов,
    //реализующих наиболее распространенные утверждения, используемые в NUnit.

    
  /*Assert.False  --  Проверяем, что указанное условие ложно
            Assert.False(30 == 20);
      
    Assert.Null  --  Проверяем, что указанный объект имеет значение null
            int? number = null;
            Assert.Null(number);
      
    Assert.Zero  --  Проверяем, что указанное число равно нулю
            int number = 0;
            Assert.Zero(number);
      
    Assert.IsEmpty  --  Проверяем, что указанная строка пустая
            string message = "";
            Assert.IsEmpty(message);*/

    #endregion


    [TestFixture]  //Именно атрибут TestFuxture указывает на то, что данный класс содержит тесты при использовании NUnit.
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100); //утверждение Assert.True(100 == 100).
                                     //Соответственно, если 100 будет равно 100,
                                     //то наш тест будет пройден успешно.
        }
    }
}
