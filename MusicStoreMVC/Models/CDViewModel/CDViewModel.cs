using MusicStore.Entities;

namespace MusicStoreMVC.Models.CDViewModel
{
    public class CDViewModel
    {
        public string AlbumTitulo { get; set; }
        public string MusicaTitulo { get; set; }
        public int Artista { get; set; }
        public int Genero { get; set; }
        public List<Artista> ListaArtista { get; set; }
        public List<Genero> ListaGenero { get; set; }

        public IEnumerable<CD> ListaCD { get; set; }
    }
}
