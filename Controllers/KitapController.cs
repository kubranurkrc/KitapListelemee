using System;
using System.Collections.Generic;
using System.Linq;
using KitapListelemee.Models;
using KitapListelemee.Repostory;
using Microsoft.AspNetCore.Mvc;

namespace KitapListelemee.Controllers;

public class KitapController : Controller
{
    private readonly RepostoryBaglantisi _repostory;

    public KitapController(RepostoryBaglantisi repostory)
    {
        _repostory = repostory;
    }
    
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Kitap() 
    {
        return View();
    }
    [HttpPost]

    public IActionResult Kitap(Kitap kitap)
    {
        _repostory.Add(kitap);
        _repostory.SaveChanges();

        return RedirectToAction("Index", "Home");
    }
    //public IActionResult GetList()
    //{
    //    List<Kitap> kitap = _repostory.Kitap.ToList();
    //    return View(kitap);
    //}
    //[HttpGet]
    //public IActionResult Details(int Id)
    //{
    //    Kitap kitap = _repostory.Kitap.Find(Id);
    //    return View(kitap);
    //}
}
