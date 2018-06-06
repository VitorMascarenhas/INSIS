using System;
using System.Collections.Generic;
using System.Text;

namespace Publicidadedigital.Models
{
    public class Destinatario
    {
        public int Id { get; set; }

        public string Localidade { get; set; }

        public string Pais { get; set; }

        public decimal Moeda { get; set; }

        public string Lingua { get; set; }

        public HashSet<Canal> Canais { get; set; }

        private Destinatario()
        {
            this.Canais = new HashSet<Canal>();
        }

        public Destinatario(string localidade, string pais, decimal moeda, string lingua) : this()
        {
            this.Localidade = localidade;
            this.Pais = pais;
            this.Moeda = moeda;
            this.Lingua = lingua;
        }

        public void AdicionarCanal(Canal canal)
        {
            this.Canais.Add(canal);
        }
    }
}
