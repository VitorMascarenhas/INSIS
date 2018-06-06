using Publicidadedigital.Models;
using PublicidadeDigital.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublicidadeDigital.API.Controllers
{
    public class CampanhasController : ApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly PublicidadeDigitalContext pdContext;

        public CampanhasController()
        {
            this.pdContext = new PublicidadeDigitalContext();
        }

        public IEnumerable<Campanha> GetAll()
        {
            return pdContext.Campanhas.ToList();
        }

        /*public CampanhasController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }*/

        


        // GET: api/Campanhas/5
        public IHttpActionResult Get(int id)
        {
            Campanha campanha = pdContext.Campanhas.FirstOrDefault(x => x.Id == id);

            if (campanha != null)
                return ResponseMessage(Request.CreateResponse<Campanha>(HttpStatusCode.OK, campanha));
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Não existem campanhas registados."));
        }

        // POST: api/Campanhas
        public IHttpActionResult Post([FromBody]Destinatario campanha)
        {
            Campanha resultado = pdContext.Campanhas.FirstOrDefault(d => d.Id == campanha.Id);

            if (resultado != null)
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.Conflict, "Já existe uma campanha registada."));
            else
            {
                pdContext.Campanhas.Add(resultado);
                pdContext.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
        }

        // PUT: api/Campanhas/5
        public IHttpActionResult Put([FromBody]Campanha Campanha)
        {
            Campanha resultado = pdContext.Campanhas.FirstOrDefault(d => d.Id == Campanha.Id);

            if (resultado != null)
            {
                resultado.Objetivo = Campanha.Objetivo;
                resultado.Identificacao = Campanha.Identificacao;
                pdContext.Campanhas.Attach(resultado);
                pdContext.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Campanha não encontrada."));
        }

        // DELETE: api/Campanhas/5
        public IHttpActionResult Delete(int id)
        {
            Campanha resultado = pdContext.Campanhas.FirstOrDefault(d => d.Id == id);

            if (resultado != null)
            {
                pdContext.Campanhas.Remove(resultado);
                pdContext.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Campanha não encontrada."));
        }

        // GET: api/Campanhas
        /*public IEnumerable<Campanha> GetAll()
        {
            return unitOfWork.CampanhaRepository.GetAll();
        }

        // GET: api/Campanhas/5
        public IHttpActionResult Get(int id)
        {
            Campanha campanha = unitOfWork.CampanhaRepository.Get(id);

            if (campanha != null)
                return ResponseMessage(Request.CreateResponse<Campanha>(HttpStatusCode.OK, campanha));
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Não existem campanhas registados."));
        }

        // POST: api/Campanhas
        public IHttpActionResult Post([FromBody]Destinatario campanha)
        {
            Campanha resultado = unitOfWork.CampanhaRepository.FirstOrDefault(d => d.Id == campanha.Id);

            if (resultado != null)
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.Conflict, "Já existe uma campanha registada."));
            else
            {
                unitOfWork.CampanhaRepository.Insert(resultado);
                unitOfWork.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
        }

        // PUT: api/Campanhas/5
        public IHttpActionResult Put([FromBody]Campanha Campanha)
        {
            Campanha resultado = unitOfWork.CampanhaRepository.FirstOrDefault(d => d.Id == Campanha.Id);

            if (resultado != null)
            {
                resultado.Objetivo = Campanha.Objetivo;
                resultado.Identificacao = Campanha.Identificacao;
                unitOfWork.CampanhaRepository.Update(resultado);
                unitOfWork.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Campanha não encontrada."));
        }

        // DELETE: api/Campanhas/5
        public IHttpActionResult Delete(int id)
        {
            Campanha resultado = unitOfWork.CampanhaRepository.FirstOrDefault(d => d.Id == id);

            if (resultado != null)
            {
                unitOfWork.CampanhaRepository.Delete(resultado);
                unitOfWork.SaveChanges();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Campanha não encontrada."));
        }*/
    }
}
