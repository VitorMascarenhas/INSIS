using System;
using System.Collections.Generic;
using System.Text;

namespace Publicidadedigital.Models
{
    public class Campanha
    {
        public int Id { get; set; }

        public string Identificacao { get; set; }

        public string Objetivo { get; set; }

        public Campanha(string identificacao, string objetivo)
        {
            this.Identificacao = Identificacao;
            this.Objetivo = objetivo;
        }
    }
}
