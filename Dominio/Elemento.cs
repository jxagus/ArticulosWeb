using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        
        //sobrescribimos el tostring para que el apartado tipo 
        public override string ToString()
        {
            return Descripcion;
        }
       
    }
}
