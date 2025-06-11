using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;


[ApiController]
[Route("mi-proyecto")]
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

    [HttpGet("presentacion")]
    public IActionResult Presentacion() {
        MongoClient client = new MongoClient(CadenaConexion.MONGO_DB);
        var db = client.GetDatabase("Escuela_Victoria_Eduardo");
        var collection = db.GetCollection<Equipo>("Equipo");

        var item = collection.Find(FilterDefinition<Equipo>.Empty).FirstOrDefault();
        return Ok(item);
    }
}
