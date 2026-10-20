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

    }
}
