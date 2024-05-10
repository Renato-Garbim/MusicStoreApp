using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Entities
{
    public class CDArtista
    {
        public int Id { get; set; }
        public int ArtistaId  { get; set; }
        public int CDId { get; set; }

        public virtual CD Cd { get; set; }
        public virtual Artista Artista { get; set; }
    }
}
