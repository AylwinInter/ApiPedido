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
    public class ProveedorController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProveedorController(AppDbContext context)
        {
            this._context = context;
        }
        // GET: api/<ProveedorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listProv =await _context.proveedor.ToListAsync();
                return Ok(listProv);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProveedorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProveedorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Proveedor proveedor)
        {
            try
            {
                _context.Add(proveedor);
                await _context.SaveChangesAsync();
                return Ok(proveedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProveedorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Proveedor proveedor)
        {
            try
            {
                if (id!=proveedor.Id_proveedor)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(proveedor);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "El proveedor se actualizó correctamente" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProveedorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var provId = await _context.proveedor.FindAsync(id);
                if (provId==null)
                {
                    return NotFound();
                }
                else
                {
                    _context.proveedor.Remove(provId);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "El proveedor fue eliminado correctamente" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
