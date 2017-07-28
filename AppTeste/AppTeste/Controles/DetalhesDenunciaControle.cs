using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Modelos;

namespace AppTeste.Controles
{
    public class DetalhesDenunciaControle
    {
        public Denuncia Denuncia { get; set; }

        public DetalhesDenunciaControle(Denuncia denuncia)
        {
            this.Denuncia = denuncia;
        }
        
    }
}
