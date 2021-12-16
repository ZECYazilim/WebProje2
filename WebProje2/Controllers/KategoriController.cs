﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;
using X.PagedList;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        [Authorize(Roles ="A")]
        public ActionResult Index(int sayfa=1)
        {
            var degerler = c.Kategoris.ToList().ToPagedList(sayfa,5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori yeniKategori)
        {
            c.Kategoris.Add(yeniKategori);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Kategoris.Find(id);
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}