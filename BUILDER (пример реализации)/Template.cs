using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__пример_реализации_
{
    /// <summary>
    /// Шаблон письма
    /// </summary>
    class Template
    {
        // заголовок
        public Header Header { get; set; }

        // тело
        public Body Body { get; set; }

        // футер или нижний колонтитул
        public Footer Footer { get; set; }

        /// <summary>
        /// Метод ToString() здесь у нас будет «собирать» контент всех элементов в единое целое и возвращать текст шаблона.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            if (Header != null)
                text.Append(Header.Text + "\n");

            if (Body != null)
                text.Append($"{Body.Text} \n");

            if (Footer != null)
                text.Append($"{Footer.Text} \n");

            return text.ToString();
        }
    }
}
