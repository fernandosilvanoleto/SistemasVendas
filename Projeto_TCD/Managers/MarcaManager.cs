using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{ 
    class MarcaManager
    {
        public static List<Marca> AllMarca()
        {
            try
            {

                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                List<Marca> marca = db.Marca.OrderBy(o => o.Nome).ToList();

                return marca;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro nas marcas", ex);
            }
        }
    }
}
