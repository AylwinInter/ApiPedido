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
    public class MenuController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MenuController(AppDbContext context)
        {
            this._context = context;
        }
        // GET: api/<MenuController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listMenu = await _context.menu.ToListAsync();
                return Ok(listMenu);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MenuController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Menu mn)
        {
            try
            {
                _context.menu.Add(mn);
                await _context.SaveChangesAsync();
                return Ok(mn);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Producto producto)
        {
            try
            {
                if (id != producto.Id_producto)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "El menu se actualizo correctamente" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var menuId = await _context.menu.FindAsync(id);
                if (menuId==null)
                {
                    return NotFound();
                }
                else
                {
                    _context.menu.Remove(menuId);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "Se eliminó correctamente el menu" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
