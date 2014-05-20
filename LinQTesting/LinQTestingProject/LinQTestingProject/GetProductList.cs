using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTestingProject
{
    class GetProductList : Product
    {
        public GetProductList()
        {

        }
        public Product p_Orange = new Orange();
        public Product p_Banana = new Banana();
    }
}
