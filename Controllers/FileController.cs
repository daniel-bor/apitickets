using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DesafioDotNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> List(int idempresa)
        {
            return Ok(new List<dynamic>()
            {
                new
                {
                    Nombre = "Hola mundo"
                }
            });
        }
    }
}

