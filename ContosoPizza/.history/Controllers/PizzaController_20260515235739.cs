using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action

    // GET by Id action
    [HttpGet]
public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();

    // POST action

    // PUT action

    // DELETE action
}