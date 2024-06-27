using ExamWeb_HaTuanAnh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_HaTuanAnh.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var dsPhim = _db.Phims.ToList();
            var tongsoPhim = _db.Phims.Sum(x => x.Id);
            ViewBag.Sum = tongsoPhim;
            return View(dsPhim);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Da them thanh cong";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            var book = _db.Phims.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        // Xử lý cập nhật chủng loại
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //cập nhật category vào table Categories
                _db.Phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Book updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form xác nhận xóa chủng loại
        public IActionResult Delete(int id)
        {
            var book = _db.Phims.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View();
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _db.Phims.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Phims.Remove(book);
            _db.SaveChanges();
            TempData["success"] = "Book deleted success";
            return RedirectToAction("Index");
        }
    }
}