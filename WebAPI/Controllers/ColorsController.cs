using Business.Abstracts;
using Entities.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
       /* private readonly IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }*/

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public IActionResult Create(Color color)
        {
            return Created("", "Merhaba");

            /* var result = _colorService.Create(color);
             if (result.Success)
             {
             }
             return BadRequest(result);*/
        }
    }
}
