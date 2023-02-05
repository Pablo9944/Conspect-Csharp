﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
  
   МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.
       
  \d    Определяет символы цифр. 
  \D 	Определяет любой символ, который не является цифрой. 
  \w 	Определяет любой символ цифры, буквы или подчеркивания. 
  \W    Определяет любой символ, который не является цифрой, буквой или подчеркиванием. 
  \s 	Определяет любой непечатный символ, включая пробел. 
  \S 	Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
   .    Определяет любой символ кроме символа новой строки. 
  \.    Определяет символ точки.
 
  
  КВАНТИФИКАТОРЫ - это символы которые определяют, где и сколько раз необходимое вхождение символов может встречаться.
 
  ^ - c начала строки. 
  $ - с конца строки. 
  + - одно и более вхождений подшаблона в строке.  
  * - 0 и более вхождений
 
 */

namespace _12.Пример_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern;

            // ШАБЛОНЫ:

            // Одно вхождение подстроки(\d+) в строку.
            //pattern = @"\d+";     // "123", "test123", "123test", "te123st", "4556yyy789"

            // Нужная подстрока(\d+) должна быть в начале строки.
            //pattern = @"^\d+";  // "123", "123test", "4556yyy789"

            // Нужная подстрока(\d+) должна быть в конце строки.
            //pattern = @"\d+$";  // "123", "test123", "4556yyy789"

            // Вся строка полностью от начала(^) и до конца($) должна соответствовать тому, что между ^ и $ (\d в данном стучае).
            pattern = @"^\d+$"; // "123"

            // И в начале и в конце строки цифры, а посередине не цифры.
            //pattern = @"^\d*\D+\d+$"; // "4556yyy789"


            var regex = new Regex(pattern);

            // Массив строк для сравнения.
            var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

            foreach (String element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }

            // Delay.
            Console.ReadKey();
        }
    }
    
}
