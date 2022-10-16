using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GurpoA.Repositorio
{
    public interface IRepositorio<T>
    {
        //- Obtiene todos los registros de una tabla del tipo de modelo T
        List<T> GetAll();

        //- Agrega un registro a una tabla T en base al modelo de tipo T
        int Save(T modelo);

        //- Actualiza un registro a una tabla T en base al modelo de tipo T
        int Update(T modelo);

        //- Elimina un registro de una tabla T en base a un ID
        int Delete(int ID);
    }
}
