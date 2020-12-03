using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveInCircle.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiveInCircle.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetLatestAlbums([FromBody]List<AlbumVM> albums)
        {
            if (albums==null)
            {
                ViewBag.Message = "Ürün Bulunamadı";
            }
            return PartialView("_singleAlbum", albums);
        }
        [HttpPost]
        public IActionResult GetDisCountAlbums([FromBody] List<AlbumVM> albums)
        {
            if (albums == null)
            {
                ViewBag.Message = "Ürün Bulunamadı";
            }
            return PartialView("_singleAlbumArea", albums);
        }
    }
}
