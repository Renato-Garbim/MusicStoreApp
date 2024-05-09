using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicStoreMVC.Controllers
{
    public class CDController : Controller
    {
        // GET: CDController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
