using ClassLibrary_GurpoA.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GurpoA.Repositorio
{
    public class PersonaRespositorio : IRepositorio<Ctr_Persona>
    {
        private DB_CustomerTestDBEntities contexto;
        public PersonaRespositorio()
        {
            contexto = DBOContext.singleton.ObtenerConexion();
        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Ctr_Persona> GetAll()
        {
            return contexto.Ctr_Persona.ToList();
        }

        public int Save(Ctr_Persona modelo)
        {
            contexto.Ctr_Persona.Add(modelo);
            return contexto.SaveChanges();
        }

        public int Update(Ctr_Persona modelo)
        {
            throw new NotImplementedException();
        }
    }
}
