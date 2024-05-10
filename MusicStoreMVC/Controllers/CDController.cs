using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Services.Interfaces;
using MusicStoreMVC.Models.CDViewModel;

namespace MusicStoreMVC.Controllers
{
    public class CDController : Controller
    {          
        private readonly IArtistaService _artistaService;
        private readonly IGeneroService _generoService;

        public CDController(IArtistaService artistaService, IGeneroService generoService)
        {
            _artistaService = artistaService;
            _generoService = generoService;
        }

        private CDViewModel CarregarViewModel()
        {
            var model = new CDViewModel();
            model.ListaArtista = _artistaService.GetAllRecords().ToList();            

            return model;
        }

        private CDEditModel CarregarEditModel()
        {
            var model = new CDEditModel();

            model.ListaArtista = _artistaService.GetAllRecords().ToList();
            model.ListaGenero = _generoService.GetAllRecords().ToList();

            return model;
        }


        // GET: CDController
        public ActionResult Index()
        {
            var model = CarregarViewModel();
            return View(model);
        }
                        
        public ActionResult Adicionar()
        {
            var model = CarregarEditModel();

            return View(model);
        }

        // POST: CDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(CDEditModel model)
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
