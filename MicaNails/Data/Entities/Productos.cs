using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicaNails.Data.Entities
{
    public class Productos
    {

        public int Id { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
