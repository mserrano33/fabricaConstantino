using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaConstantino.BD.Data.Entidad
{
    
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DirecciondeEnvio { get; set; }
        public string DireccionPredeterminada { get; set; }
        public int Telefono { get; set; }
    }
}
