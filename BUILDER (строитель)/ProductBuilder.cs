using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__строитель_
{
    /// <summary>
    ///  Реализация строителя конкретного продукта
    /// </summary>
    class ProductBuilder : IBuilder
    {
        Product product = new Product();

        // 1-й этап
        public void FirstStage()
        {
            product.Add("Part one");
        }

        // 2-й этап
        public void SecondStage()
        {
            product.Add("Part two");
        }

        // 3-й этап
        public void ThirdStage()
        {
            product.Add("Part three");
        }

        // 4-й этап
        public Product GetBuildingResult()
        {
            return product;
        }
    }
}
