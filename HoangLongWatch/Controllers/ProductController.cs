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
        public ActionResult Index(int page = 1, int pageSize = 8)
        {
            var dao = new ProductDao();
            int totalRecord = 0;
            var model = dao.ListProducts(ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;
            int totalPage = 0;
            double temp = (double)totalRecord / pageSize;
            totalPage = (int)Math.Ceiling(temp);
            ViewBag.TotalPage = totalPage;
            ViewBag.MaxPage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = totalPage;
            ViewBag.Next = page + 1;
            ViewBag.Prev = page - 1;
            return View(model);
        }
        public ActionResult Detail(long id)
        {
            var product = new ProductDao().Detail(id);
            return View(product);
        }
    }
}