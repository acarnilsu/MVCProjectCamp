using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectCamp.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager imagefileManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = imagefileManager.GetList();
            return View(files);
        }
    }
}