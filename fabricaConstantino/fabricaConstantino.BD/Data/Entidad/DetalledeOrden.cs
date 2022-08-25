using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricadeSandwiches.BD.Data.Entidad
{
    
    public class DetalledeOrden
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Producto { get; set; }
        public string Precio { get; set; }
        public int Cantidad { get; set; }

    }
}
