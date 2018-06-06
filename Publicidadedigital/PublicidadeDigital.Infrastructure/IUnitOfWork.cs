using PublicidadeDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublicidadeDigital.Infrastructure
{
    public interface IUnitOfWork
    {
        ICampanhaRepository CampanhaRepository { get; }

        IDestinatarioRepository DestinatarioRepository { get; }

        void SaveChanges();
    }
}
