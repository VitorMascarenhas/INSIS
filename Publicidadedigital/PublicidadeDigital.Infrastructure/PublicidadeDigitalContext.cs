using Publicidadedigital.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PublicidadeDigital.Infrastructure
{
    public class PublicidadeDigitalContext : DbContext
    {
        public PublicidadeDigitalContext() : base("PDConnectionString")
        {
        }

        public DbSet<Campanha> Campanhas { get; set; }

        //public DbSet<Destinatario> Destinatarios { get; set; }
    }
}
