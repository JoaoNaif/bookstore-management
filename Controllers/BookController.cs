using LibraryChalenger.Dto;
using LibraryChalenger.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryChalenger.Controllers;

[Route("library/[controller]")]
[ApiController]
public class BookController : Controller
{
    
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult Get([FromRoute] string id)
    {
        var response = new Book
        {
            Id = "1",
            Title = "Book 1",
            Author = "Author 1",
            Gender = Gender.Ficção,
            Price = 234,
            Quantity = 12344
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] CreateBookRequest request)
    {
        var response = new Book
        {
            Id = Guid.NewGuid().ToString(),
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price,
            Quantity = request.Quantity,
        };
        
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] UpdateBookRequest request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] string id)
    {
        return NoContent();
    }
}