namespace MusicStoreMVC.Entidades
{
    public class CD : EntityBase
    {
        public int Id { get; set; }
        public int GeneroId { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public virtual ICollection<Musica> Musicas { get; set; }
        public virtual Genero Genero { get; set; }


    }
}
