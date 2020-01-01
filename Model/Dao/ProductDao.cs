using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductDao
    {
        OnlineShopDbContext db = null;
        public ProductDao()
        {
            db = new OnlineShopDbContext();
        }

        public List<Product> ListAllProducts()
        {
            return db.Products.ToList();
        }

        public Product Detail(long id)
        {
            return db.Products.Find(id);
        }
    }
}
