using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("api/controller")]
    public class MiProyectoController : ControllerBase
    {
        [HttpGet("Integrantes")]
        public ActionResult<MiProyecto> Integrantes()
        {
            var proyecto = new MiProyecto
            {
                Integrante1 = "Ana Victoria Silva Gonzalez",
                Integrante2 = "Eduardo Valdez Ochoa"
            };

            return Ok(proyecto);
        }
    }
