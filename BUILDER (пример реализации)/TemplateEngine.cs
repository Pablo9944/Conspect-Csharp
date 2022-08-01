using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__пример_реализации_
{
    /// <summary>
    /// Движок шаблонизатора
    /// </summary>
    class TemplateEngine
    {
        /// <summary>
        /// Метод поэтапной генерации шаблона рассылки
        /// </summary>
        public Template GenerateTemplate(TemplateBuilder templateBuilder)
        {
            templateBuilder.CreateTemplate();

            templateBuilder.BuildHeader();
            templateBuilder.BuildBody();
            templateBuilder.BuildFooter();

            return templateBuilder.Template;
        }
    }
}
