using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{
    public class TransportadoraManager
    {
        public static List<Transportadora> All()
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                List<Transportadora> trans = db.Transportadora.OrderBy(o => o.Nome).ToList();
                return trans;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar nas transportadoras", ex);
            }
        }
    }
}
