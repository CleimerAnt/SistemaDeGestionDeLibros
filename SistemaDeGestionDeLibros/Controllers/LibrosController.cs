using Application.DTOS.LibroDTO;
using Application.Infraestructure.Commands;
using Application.Infraestructure.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SistemaDeGestionDeLibros.Controllers
{
    public class LibrosController : Controller
    {
        private readonly IMediator _mediator;
        public LibrosController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet("Get all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GetLibroDTO>>> GetAllLibros()
        {
            var libros = await _mediator.Send(new GetAllLibrosQuery());

            return Ok(libros);
        }

        [HttpGet("Id")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetLibroDTO>> GetLibrosById(int Id)
        {
            var query = new GetLibroByIdQuery(Id);
            var libro = await _mediator.Send(query);
            if(libro == null) return NotFound();    

            return Ok(libro);
        }
        [HttpGet("Genero")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetLibroDTO>> GetLibrosByGenero(string Genero)
        {
            var query = new GetLibroByGeneroQuery(Genero);
            var libro = await _mediator.Send(query);
            if (libro == null) return NotFound();

            return Ok(libro);
        }
        [HttpPost("Post")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateLibroDTO>> AddLibro(CreateLibroCommand command)
        {
            var libro = await _mediator.Send(command);  
            return Ok(libro);   
        }
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CreateLibroDTO>> UpdateLibro(int Id,UpdateLibroCommand command)
        {
            if(Id != command.Id)
            {
                return BadRequest();    
            }

            var libro = await _mediator.Send(command);
            if(libro == null)
            {
                return NotFound();  
            }

            return NoContent();
        }
    }
}
