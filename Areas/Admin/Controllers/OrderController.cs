using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using PagedList;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var item = db.Orders.OrderByDescending(x => x.CreatedDate).ToList();
           
            if(page == null)
            {
                page = 1;

            }
            var pageNumber = page ?? 1;
            var pageSize = 15;
            return View(item.ToPagedList(pageNumber,pageSize));
        }
    }
}