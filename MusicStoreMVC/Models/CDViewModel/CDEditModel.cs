
using MusicStore.Entities;

namespace MusicStoreMVC.Models.CDViewModel
{
    public class CDEditModel
    {
        public List<Artista> ListaArtista { get; set; }
        public List<Genero> ListaGenero { get; set; }
        public int GeneroId { get; set; }
        public int ArtistaId { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }


    }
}
