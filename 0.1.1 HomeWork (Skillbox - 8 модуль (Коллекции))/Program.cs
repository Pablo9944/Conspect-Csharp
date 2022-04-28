using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Работа с листом 

            /* Создайте лист целых чисел. 
            Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
            Выведите коллекцию чисел на экран. 
            Удалите из листа числа, которые больше 25, но меньше 50. 
            Снова выведите числа на экран.*/


            //List l = new List();
            //l.Print();
            //Console.WriteLine($"Остаток = {l.Count}");
            //Console.ReadKey();
            //Console.WriteLine();

            //Console.Clear();
            //l.Remove();
            //l.Print(); 
            //Console.WriteLine($"Остаток = {l.Count}");
            //Console.ReadKey();




            #endregion

            #region Dictionary
            /*
                * Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
            В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, 
            а значением — ФИО владельца. Таким образом, у одного владельца может быть несколько номеров телефонов. 
            Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
            Далее программа предлагает найти владельца по введенному номеру телефона. 
            Пользователь вводит номер телефона и ему выдаётся ФИО владельца. 
            Если владельца по такому номеру телефона не зарегистрировано, 
            программа выводит на экран соответствующее сообщение.*/


            //Dictionary d = new Dictionary();

            //var dic = d.AddContact();
            ////d.Print(dic);
            //d.Find(dic,"123");




            #endregion

            #region HashSet
            //Пользователь вводит число.Число сохраняется в HashSet коллекцию.
            //Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение,
            //что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, что число успешно сохранено. 


            //HashSets hs = new HashSets();
            //hs.Add();

            #endregion

            #region XElement Записная книжка
            /*<Person name=”ФИО человека” >
                  <Address>
                    <Street>Название улицы</Street>
                    <HouseNumber>Номер дома</HouseNumber>
                    <FlatNumber>Номер квартиры</FlatNumber>
                 </Address>
                 <Phones>
                    <MobilePhone>89999999999999</MobilePhone>
                    <FlatPhone>123-45-67<FlatPhone>
                 </Phones>
             </Person>*/


            //XElement Person = new XElement("Person");
            //XAttribute name = new XAttribute("name","ФИО человека");

            //XElement Address = new XElement("Address");
            //XElement Street = new XElement("Address","Нзавнвание улицы");
            //XElement HouseNumber = new XElement("HouseNumber", "Номер дома");
            //XElement FlatNumber = new XElement("FlatNumber", "Номер квартиры");



            //XElement Phones = new XElement("Phones");
            //XElement MobilePhone = new XElement("MobilePhone", "89999999999999");
            //XElement FlatPhone = new XElement("FlatPhone", "123-45-67");
 
            //Phones.Add(MobilePhone, FlatPhone);
            //Address.Add(Street, HouseNumber, FlatNumber);
            
            //Person.Add(Address, Phones);
            //Person.Add(name);
            //Person.Save(@"E:\HW.xml");

            #endregion
        }
    }
}
