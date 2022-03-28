using BackOphelia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackOphelia2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly OpheliaDBContext _context;


        public DetalleController(OpheliaDBContext context)
        {
            _context = context;
        }
        // GET: api/<DetalleController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (OpheliaDBContext db = new OpheliaDBContext())
                {
                    var listDetalle = db.DetalleVenta.ToList();
                    return Ok(listDetalle);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<DetalleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DetalleVentum detalle)
        {
            try
            {
                _context.Add(detalle);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Detalle creado con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<DetalleController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DetalleVentum detalle)
        {
            try
            {
                if (id != detalle.IdDetalle)
                {
                    return NotFound();
                }
                _context.Update(detalle);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Detalle actualizado con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<DetalleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var detalle = await _context.DetalleVenta.FindAsync(id);
                if (detalle == null)
                {
                    return NotFound();
                }
                _context.DetalleVenta.Remove(detalle);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Detalle eliminado" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
