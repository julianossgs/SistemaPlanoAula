using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanodeAulas
{
    public class PlanoEnt
    {
        public int IdPlano { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Eixo { get; set; }
        public string Objetivo { get; set; }
        public string Conteudo { get; set; }
        public string Metodologia { get; set; }
        public string Avaliacao { get; set; } 
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

    }
}
