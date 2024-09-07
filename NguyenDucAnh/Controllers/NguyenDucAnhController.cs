using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenDucAnh.Controllers
{
    public class NguyenDucAnhController : Controller
    {
        // GET: NguyenDucAnh
        public ActionResult DanhSach()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult NavPartial()
        {
            return PartialView();
        }
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
        public ActionResult ChuDePartial()
        {
            return PartialView();
        }
        public ActionResult NhaXuatBanPartial()
        {
            return PartialView();
        }
        public ActionResult SachBanNhieuPartial()
        {
            return PartialView();
        }
        public ActionResult FooterPartial()
        {
            return PartialView();
        }
    }
}