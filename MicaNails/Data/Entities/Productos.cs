using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicaNails.Data.Entities
{
    public class Productos
    {

        public int Id { get; set; }
        [DisplayName("Código")]
        public string CodProducto { get; set; }
        [DisplayName("Nombre del Producto ")]
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
