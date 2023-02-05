using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeWork__Описание_
{
    // Атрибуты. (Аспектно-Ориентированное Программирование)
    // Атрибуты могут использоваться перед объявлениями типов, 
    // членов класса, членов интерфейса и перечислений.
    // Виды атрибутов: Предопределенные и Пользовательские.
    // [ ....... ] - секция атрибута.
    // Объявление атрибута состоит из Имени атрибута и набора Параметров.
    // Для атрибутов определяют два вида параметров - Позиционные и Именованные. 
    // Именованные параметры всегда располагаются после Позиционных.

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class MyAttribute : Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        // Позиционные параметры задаются формальными параметрами - public конструктора, класса атрибута.
        public MyAttribute(string date)
        {
            this.date = date;
        }

        // Именованные параметры задаются открытыми нестатическими полями или свойствами, класса атрибута.
        public int Number { get; set; }
    }

}