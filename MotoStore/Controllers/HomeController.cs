using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MotoStore.Models;


namespace MotoStore.Controllers
{
    public class HomeController : Controller
    {
        MotoContext db = new MotoContext();
        public ActionResult Index(int page=1)
        {
            int pageSize = 6;//Количество элементов на странице
           IEnumerable<Motobike> motoInPages=db.Motobikes.OrderBy(x=>x.Id)//Достаем из БД элементы                
                .Skip((page-1)*pageSize)//Пропускаем нужное кол-во элементов
                .Take(pageSize);//Берем нужное кол-во
            PageInfo pageInfo = new PageInfo
            {
                PageNumber = page, 
                PageSize = pageSize, 
                TotalItems = db.Motobikes.Count()
            };
            IndexViewModel ivm = new IndexViewModel
            {
                PageInfo = pageInfo,
                Motobikes = motoInPages
            };    
            return View(ivm);// ПЕРЕДАЕМ в представление список товаров
        }
        [HttpGet]//Get: метод покупки
        public ActionResult Buy(int Id)// Принимаем в параметр идентификатор товара 
        {
            ViewBag.MotoId = Id;    //*
            return View();//Товар отправляем в представление
        }
       
        [HttpPost]//Post:  метод покупки
        
        public string Buy(Purchase purchase)//В параметр принимает покупателя
        {
            purchase.Date = DateTime.Now;//Дата совершения покупки
            db.Purchases.Add(purchase);// Добавляем покупателя в БД
            db.SaveChanges();// Сохраняем БД
            DeleteConfirmed(purchase.MotoId);// Удаляем из каталога купленный товар
            return "<h3> Спасибо, " + purchase.Person + ", за покупку!<br/>Мы доставим на указанный адрес.</h3>";
        }
        public ActionResult GetMoto(int id)
        {
            Motobike mt = db.Motobikes.Find(id);
            if (mt == null) return HttpNotFound();
            return View(mt);
        }
        [HttpGet]// Изменение данных товара
        public ActionResult Edit(int? id)
        {
            if (id == null) return HttpNotFound();
            Motobike motobike = db.Motobikes.Find(id);
            if (motobike == null) return HttpNotFound();
            var bikes = db.Motobikes;
            SelectList names = new SelectList(bikes.Select(p => p.Name).Distinct());
            ViewBag.Names = names;
            SelectList companyes = new SelectList(bikes.Select(p => p.Company).Distinct());
            ViewBag.Companyes = companyes;
            SelectList prices = new SelectList(bikes.Select(p => p.Price).Distinct());
            ViewBag.Prices = prices;
            return View(motobike);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, Company, Price, Class, Color, Existence, YearManufacture, Power")] Motobike ph)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ph).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ph);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Motobike ph = db.Motobikes.Find(id);
            if (ph == null) return HttpNotFound();
            return View(ph);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Motobike ph = db.Motobikes.Find(id);
            if (ph == null) return HttpNotFound();
            db.Motobikes.Remove(ph);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View(new Motobike());
        }
        [HttpPost]
        public ActionResult CreateProduct([Bind(Include = "Id, Name, Company, Price, Class, Color, Existence, YearManufacture, Power")]Motobike mt)
        {
            
            if (ModelState.IsValid)
            {  
                db.Motobikes.Add(mt);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(mt);
        }
        public ActionResult Index1()
        {
            IEnumerable<Purchase> purchases = db.Purchases.OrderBy(m => m.Person);
            return View(purchases);
        }
        [HttpGet]
        public ActionResult EditPerson(int? id)
        {
            if (id == null) return HttpNotFound();
            Purchase pr = db.Purchases.Find(id);
            if (pr == null) return HttpNotFound();
            var purchase = db.Purchases;
            SelectList names = new SelectList(purchase.Select(p => p.Person).Distinct());
            ViewBag.Names = names;
            SelectList adress = new SelectList(purchase.Select(p => p.Address).Distinct());
            ViewBag.Addreses = adress;
            SelectList dates = new SelectList(purchase.Select(p => p.Date).Distinct());
            ViewBag.Dates = dates;
            return View(pr);
        }
        [HttpPost]
        public ActionResult EditPerson(Purchase pr)
        {
            db.Entry(pr).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
        [HttpGet]
        public ActionResult DeletePerson(int id)
        {
            Purchase pr = db.Purchases.Find(id);
            if (pr == null) return HttpNotFound();
            return View(pr);
        }
        [HttpPost, ActionName("DeletePerson")]
        public ActionResult DeletePurchase(int id)
        {
            Purchase pr = db.Purchases.Find(id);
            if (pr == null) return HttpNotFound();
            db.Purchases.Remove(pr);
            db.SaveChanges();
            return RedirectToAction("Index1");

        }
        
    }
}