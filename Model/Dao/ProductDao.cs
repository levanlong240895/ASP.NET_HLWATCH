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

        public List<Product> ListProducts(ref int totalRecord, int pageIndex, int pageSize)
        {
            totalRecord = db.Products.Count();
            //return db.Products.ToList();
            return db.Products
                .OrderByDescending(x => x.ID)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public Product Detail(long id)
        {
            return db.Products.Find(id);
        }
    }
}
