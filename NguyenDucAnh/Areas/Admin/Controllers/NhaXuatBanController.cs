using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDucAnh.Models;

namespace NguyenDucAnh.Areas.Admin.Controllers
{

    public class NhaXuatBanController : Controller
    {
        SachOnlineEntities db = new SachOnlineEntities();

        // GET: Admin/NhaXuatBan
        public ActionResult Index()
        {
            var data = db.NHAXUATBANs.ToList();
            return View(data);
        }
        public ActionResult Details()
        {
            int maNXB = int.Parse(Request.QueryString["id"]);
            var kq = db.NHAXUATBANs.Where(nxb=>nxb.MaNXB ==maNXB).SingleOrDefault();
            return View(kq);
        }
    }
}