﻿

class Program
{
    static void Main()
    {
        #region

        // Этот поведенческий паттерн позволяет нам превратить запросы в объекты и передавать их потом как аргументы при вызове методов.
        // Мы можем ставить запросы в очередь, отслеживать в логах. Также, если необходимо, мы можем их отменять.
        // Командой при этом и является сам запрос на выполнение определенного действия.
        // Ещё одно преимущество состоит в том, что команды могут использоваться разными объектами. К ним может быть открыт доступ из разных, не зависящих друг от друга мест программы.



        /*Итак, когда используем?

          Нам надо передать в виде параметров какие-то действия, и в ответ мы должны получить другие действия. То есть нам нужно получить обратный ответ.
          Нам нужна очередь запросов, а также возможность их отмены.
          Нам нужно контролировать изменения в логах и отслеживать поведение нашей системы. Это нам также поможет восстановить систему в случае сбоев.*/

        #endregion
    }
}