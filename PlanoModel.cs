using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanodeAulas
{
    public class PlanoModel
    {
        internal List<PlanoEnt> ListarPlanos()
        {
            return new PlanoController().ListarPlanos();
        }

        internal static int Inserir(PlanoEnt obj)
        {
            return new PlanoController().Inserir(obj);
        }

        internal static int Excluir(PlanoEnt obj)
        {
            return new PlanoController().Excluir(obj);
        }

        internal static int Alterar(PlanoEnt obj)
        {
            return new PlanoController().Alterar(obj);
        }

        internal List<PlanoEnt> BuscarDatas(PlanoEnt obj)
        {
            return new PlanoController().BuscarDatas(obj);
        }
    }
}
