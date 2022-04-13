using ApiPedido.Context;
using ApiPedido.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPedido.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RolesController(AppDbContext context)
        {
            this._context = context;
        }

        // GET: api/<RolesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listRol =await _context.rol.ToListAsync();
                return Ok(listRol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Rol rol)
        {
            try
            {
                _context.Add(rol);
                await _context.SaveChangesAsync();
                return Ok(rol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                }
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Rol rol)
        {
            try
            {
                if (id!=rol.Id_rol)
                {
                    return NotFound();
                }
                _context.Update(rol);
                await _context.SaveChangesAsync();
                return Ok(new { message = "EL rol fue actualizado correctamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var rolId = await _context.rol.FindAsync(id);
                if (rolId==null)
                {
                    return NotFound();
                }
                _context.rol.Remove(rolId);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Se eliminó correctamente el rol" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
