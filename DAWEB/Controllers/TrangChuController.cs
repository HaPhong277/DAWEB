using DAWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace DAWEB.Controllers
{
    public class TrangChuController : Controller
    {
        WebDataEntities3 db = new WebDataEntities3();
        // GET: TrangChu
        public ActionResult Index()
        {
            // tạo dbContext
            // lấy ra danh sách các sản phẩm truy vấn dữ liệu từ Category
            List<SanPham> lst = db.SanPham.ToList();
            var check1 = (from item in db.SanPham orderby item.Gia ascending select item).ToList();
            var check2 = (from item in db.SanPham orderby item.Gia descending select item).ToList();
            return View(lst);
        }
        public ActionResult SanPham(int? Category, string Search)
        {
            List<SanPham> lst;
            if (Category == null && Search == null)
            {
                lst = db.SanPham.ToList();
            }
            else
            {
                if (Category != null)
                {
                    lst = db.SanPham.Where(x => x.IdSP == Category).ToList();
                }
                else
                {
                    lst = db.SanPham.Where(x => x.Name.Contains(Search)).ToList();
                }
            }

            ViewBag.IdSP = new SelectList(db.DanhMucSanPham.ToList(), "Id", "Name");
            return View(lst);
        }
        public ActionResult Detail(int id)
        {
            var objproduct = db.SanPham.Where(n => n.Id == id).FirstOrDefault();
            return View(objproduct);
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
    }
}