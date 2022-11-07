using fabricaConstantino.BD.Data;
using fabricaConstantino.BD.Data.Entidad;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fabricadeSandwiches.Server.Controllers
{
    [ApiController]
    [Route("api/Fabrica")]
    public class FabricaController : ControllerBase
    {
        private readonly Bdcontext context;

        public FabricaController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            return await context.Productos.ToListAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            var producto = await context.Productos.Where(
                e => e.Id == id).FirstOrDefaultAsync();
            if (producto == null)
            {
                return NotFound($"No existe la especialidad de Id={id}");
            }
            return producto;
        }

        [HttpPost]

        public async Task<ActionResult<Producto>> Post(Producto producto)
        {
            try
            {           ///el contxt salve los cambios en el sql server, 
                        ///y si todo esta bien voya retornar ok
                        ///actualiza el objeto con id qeu le asigno sin cambiar
                context.Productos.Add(producto);
                await context.SaveChangesAsync();
                return producto;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);

            }



        }
        
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var pepe = context.Productos.Where(x => x.Id == id).FirstOrDefault();

            if (pepe == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }

            try
            {
                context.Productos.Remove(pepe);
                context.SaveChanges();
                return Ok($"El registro de {pepe.Nombre} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }


    }

}
