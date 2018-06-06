using Publicidadedigital.Models;
using PublicidadeDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PublicidadeDigital.Infrastructure
{
    public class DestinatarioRepository : BaseRepository<Destinatario, int>, IDestinatarioRepository
    {
        public DestinatarioRepository(DbContext context) : base(context)
        {
        }
    }
}
