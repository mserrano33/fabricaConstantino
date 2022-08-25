using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricadeSandwiches.BD.Data.Entidad
{   
    
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }

        public string Miniatura { get; set; }

        public string Imagen { get; set; }

        public string Categoria { get; set; }

        public string Fecha_de_creacion { get; set; }

        public string Stock { get; set; }

    }
}
