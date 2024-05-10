using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Entities.Base;

namespace MusicStore.Entities
{
    public class Genero : EntityBase
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<CD> CDs { get; set; }
    }
}
