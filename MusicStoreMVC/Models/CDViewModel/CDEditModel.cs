
using MusicStore.Entities;

namespace MusicStoreMVC.Models.CDViewModel
{
    public class CDEditModel
    {
        public List<Artista> ListaArtista { get; set; }
        public List<Genero> ListaGenero { get; set; }
        public List<Musica> Musicas { get; set; }
        public CD Album { get; set; }
        public int ArtistaId { get; set; }

        public string TituloMusica { get; set; }
        public decimal DuracaoMusica { get; set; }

    }
}
