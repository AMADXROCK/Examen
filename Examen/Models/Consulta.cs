using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Consulta
    {
        ExamenEntities BD = new ExamenEntities();
        public Clientes consultar(int? id)
        {
            try
            {
                var informacion = from c in BD.Clientes
                                  join a in BD.Asociados
                                  on c.IDCliente equals a.IDCliente
                                  where a.IDCliente == id
                                  select c;
                return informacion.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
            
    }
}