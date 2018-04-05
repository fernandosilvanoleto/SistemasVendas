using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{
    public class GerenteManager
    {
        public static int LocalizarGerente(int cod)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();


                Gerente ger = db.Gerente.SingleOrDefault(o => o.idGerente == cod);
                int codGer = ger.idGerente;
                return codGer;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar localizar gerente", ex);
            }
        }
    }
}
