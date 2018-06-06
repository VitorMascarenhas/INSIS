using PublicidadeDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PublicidadeDigital.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        private ICampanhaRepository campanhaRepository;
        public ICampanhaRepository CampanhaRepository
        {
            get
            {
                if (campanhaRepository == null)
                {
                    campanhaRepository = new CampanhaRepository(this.context);
                }
                return campanhaRepository;
            }
        }

        private IDestinatarioRepository destinatarioRepository;
        public IDestinatarioRepository DestinatarioRepository
        {
            get
            {
                if (destinatarioRepository == null)
                {
                    destinatarioRepository = new DestinatarioRepository(this.context);
                }
                return destinatarioRepository;
            }
        }

        public void SaveChanges()
        {
            //TODO: Ver transaction
            context.SaveChanges();
        }
        
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
