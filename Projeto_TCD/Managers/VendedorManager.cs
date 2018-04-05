using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{
    public class VendedorManager
    {
        public static List<Vendedor> All()
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                List<Vendedor> vendedor = db.Vendedor.OrderBy(o => o.Nome).ToList();
                return vendedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro em vendedores", ex);
            }
        }
    }
}
