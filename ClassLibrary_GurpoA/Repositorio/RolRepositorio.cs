using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_GurpoA.Modelo;

namespace ClassLibrary_GurpoA.Repositorio
{
    public class RolRepositorio : IRepositorio<Ctr_Rol>
    {
        private DB_CustomerTestDBEntities contexto;
        public RolRepositorio()
        {
            contexto = DBOContext.singleton.ObtenerConexion();
        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Ctr_Rol> GetAll()
        {
            return contexto.Ctr_Rol.ToList();
        }

        public int Save(Ctr_Rol modelo)
        {
            contexto.Ctr_Rol.Add(modelo);
            return contexto.SaveChanges();
        }

        public int Update(Ctr_Rol modelo)
        {
            contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
            return contexto.SaveChanges();
        }
    }
}
