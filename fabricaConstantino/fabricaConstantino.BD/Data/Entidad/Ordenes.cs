using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaConstantino.BD.Data.Entidad
{
    
    public class Ordenes
    {
        public int Id { get; set;}
        public int Id_cliente { get; set;}
        public int Cantidad { get; set;}
        public string DirecciondeEnvio { get; set;}
        public string EstadodePedido { get; set;}

    }
}
