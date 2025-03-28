using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        //public string Marca { get; set; }
        //public string Tipo { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
  
        public decimal Precio { get; set; }
        public Elemento Categoria { get; set; }
        public Elemento Marca { get; set; }
        



    }
}
