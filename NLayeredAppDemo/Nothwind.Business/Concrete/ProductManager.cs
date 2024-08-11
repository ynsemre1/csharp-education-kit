using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nothwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();

        public List<Product> GetAll()
        {
            //Bussines Code
            return _productDal.GetAll();
        }
    }
}
