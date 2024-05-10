using MusicStore.Entities;
using MusicStore.Repositories.Interfaces;
using MusicStore.Services.Base;
using MusicStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services
{
    public class CDService : ServiceBase<CD>, ICDService
    {
        private readonly ICDRepository _CDRepository;
        
        public CDService(ICDRepository CDRepository) : base(CDRepository) 
        {
            _CDRepository = CDRepository;
        }
    }
}
