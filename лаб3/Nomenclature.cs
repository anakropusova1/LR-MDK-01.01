using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб3
{
    public class Nomenclature
    {
        private Dictionary<ProductGroup, List<string>> products_;

        public Nomenclature()
        {
            products_ = new Dictionary<ProductGroup, List<string>>();
        }
        public List<string> GetAllProductsGroup(ProductGroup productGroup)
        {
            if (products_.ContainsKey(productGroup))
            {
                return products_[productGroup];
            }
            return new List<string>();
        }

        public void AddProduct(ProductGroup productGroup, string productName)
        {
            if (!products_.ContainsKey(productGroup))
            {
                products_[productGroup] = new List<string>();
            }

            products_[productGroup].Add(productName);
        }
        public ProductGroup? GetProductGroupByProduct(string product)
        {
            foreach (KeyValuePair<ProductGroup, List<string>> productGroups in products_)
            {
                if (productGroups.Value.Contains(product))
                {
                    return productGroups.Key;
                }
            }
            return null;
        }
    }
}
