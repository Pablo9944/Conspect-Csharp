﻿

using Prototype__ПРОТОТИП_;

class Program
{
    static void Main()
    {
        #region Описание

        // Как и следует из названия, этот паттерн позволяет копировать уже имеющиеся объекты, а если точнее, позволяет это делать самим объектам.

        /*Итак, когда используем? 

        Если нам надо динамически определять тип создаваемого объекта во время выполнения и убрать его зависимость от копируемого объекта.
        Если клонирование объекта для нас предпочтительнее, чем его создание и инициализация в конструкторе. Особенно удобно, когда мы знаем, что объект способен принимать небольшое ограниченное количество возможных состояний.
        
        */

        #endregion

        #region Описание действий

        // 1) Создаем абстрактный прототип: abstract class Prototype
        // 2) Теперь две конкретные реализации: class ClassOne и class ClassTwo

        #endregion

        //  создаем первый конкретный объект по прототипу
        Prototype prototype = new ClassOne(1);
        // Клонируем
        Prototype clone = prototype.Clone();

        //  создаем второй конкретный объект по прототипу
        prototype = new ClassTwo(2);
        // Клонируем
        clone = prototype.Clone();
    }
}