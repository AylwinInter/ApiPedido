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
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            this._context = context;
        }
        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                using (_context)
                {
                    var person = await (from r in _context.rol join u in _context.usuario on r.Id_rol equals u.rol select new { 
                        u.Id_user,
                        u.first_name,
                        u.last_name,
                        u.direction,
                        u.phone,
                        u.usuario,
                        u.password,
                        r.rol
                    }).ToListAsync();
                    return Ok(person);
                }
                   /* var listUser = await _context.usuario.Join(_context.rol, user => user.Id_user, r => r.Id_rol,
                        (user, r) => new {
                            Id_user = user.Id_user,
                            firt_name = user.first_name,
                            last_name = user.last_name,
                            direction = user.direction,
                            phone = user.phone,
                            usuario = user.usuario,
                            password = user.password,
                            r.rol }).ToListAsync();
                
                return Ok( listUser);*/
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}", Name ="GetUsuario")]
        public ActionResult Get(int id)
        {
            try
            {
                var user = _context.usuario.FirstOrDefault(u=>u.Id_user==id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult Post([FromBody]Usuario agregar)
        {
            try
            {
                _context.usuario.Add(agregar);
                _context.SaveChanges();
                return CreatedAtRoute("GetUsuario", new { id = agregar.Id_user }, agregar);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Usuario agregar)
        {
            try
            {
                if (agregar.Id_user==id)
                {
                    _context.Entry(agregar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetUsuario", new { id = agregar.Id_user }, agregar);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var user = _context.usuario.FirstOrDefault(u => u.Id_user == id);
                if (user!=null)
                {
                    _context.usuario.Remove(user);
                    _context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
