using Publicidadedigital.Models;
using PublicidadeDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PublicidadeDigital.Infrastructure
{
    public class CampanhaRepository : BaseRepository<Campanha, int>, ICampanhaRepository
    {
        public CampanhaRepository(DbContext context) : base(context)
        {
        }
    }
}
