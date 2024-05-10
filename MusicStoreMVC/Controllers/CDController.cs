using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Entities;
using MusicStore.Services.Interfaces;
using MusicStoreMVC.Models.CDViewModel;

namespace MusicStoreMVC.Controllers
{
    public class CDController : Controller
    {          
        private readonly IArtistaService _artistaService;
        private readonly IGeneroService _generoService;
        private readonly ICDService _cdService;
        private readonly ICDArtistaService _cdArtistaService;
        private readonly IMusicaService _musicaService;


        public CDController(IArtistaService artistaService, IGeneroService generoService, ICDService cdService, ICDArtistaService cdArtistaService, IMusicaService musicaService)
        {
            _artistaService = artistaService;
            _generoService = generoService;
            _cdService = cdService;
            _cdArtistaService = cdArtistaService;
            _musicaService = musicaService;
        }

        private CDViewModel CarregarViewModel(CDViewModel model = null)
        {
            if(model == null)
            {
                model = new CDViewModel();
            }
            
            model.ListaArtista = _artistaService.GetAllRecords().ToList();
            model.ListaGenero = _generoService.GetAllRecords().ToList();
            
            model.ListaCD = _cdService.FiltrarCdPor(model.AlbumTitulo, model.MusicaTitulo, model.Genero, model.Artista);

            return model;
        }

        private CDEditModel CarregarEditModel(int id = 0)
        {
            var model = new CDEditModel();

            if (id == 0)
            {
                model.Album = new CD();
            }
            else
            {
                model.Album = _cdService.GetRecordById(id);
                model.ArtistaId = _cdArtistaService.ObterArtistaIdPor(id);
                model.Musicas = _musicaService.ObterRegistrosPor(model.ArtistaId).ToList();
            }
            
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

        public ActionResult Pesquisar(CDViewModel model)
        {
            model = CarregarViewModel(model);
            return View("Index", model);
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
                var inseridoSucesso = _cdService.InsertRecord(model.Album);

                if (inseridoSucesso)
                {
                    var cdId = _cdService.ObterCDIdPor(model.Album.Titulo, model.Album.Ano);

                    var novoCdArtista = new CDArtista() { CDId = cdId, ArtistaId = model.ArtistaId };

                    bool retorno = _cdArtistaService.InsertRecord(novoCdArtista);
                    
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarMusica(CDEditModel model)
        {
            try
            {
                var novaMusica = new Musica() { ArtistaId = model.ArtistaId, titulo = model.TituloMusica, duracao = model.DuracaoMusica };

                var inseridoSucesso = _musicaService.InsertRecord(novaMusica);

                if (inseridoSucesso)
                {

                }

                return RedirectToAction("Edit", new {id = model.Album.Id});
            }
            catch
            {
                return View();
            }
        }

        // GET: CDController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = CarregarEditModel(id);

            return View(model);
        }

    }
}
