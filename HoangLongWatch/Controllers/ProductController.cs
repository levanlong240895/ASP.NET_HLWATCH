using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HoangLongWatch.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var dao = new ProductDao();
            //var model = dao.ListAllPaging(searchString, page, pageSize);
            var model = dao.ListAllProducts();
            return View(model);
        }
        public ActionResult Detail(long id)
        {
            var product = new ProductDao().Detail(id);
            return View(product);
        }
    }
}