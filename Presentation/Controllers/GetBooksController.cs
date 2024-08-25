using System;
using Microsoft.AspNetCore.Mvc;
using teste.Domain.UseCases;

namespace teste.Presentation.Controllers;

public class GetBooksController : ControllerBase
{
    private readonly IGetBooks _getBooks;
    
    public GetBooksController(IGetBooks getBooks)
    {
        _getBooks = getBooks;
    }

    [HttpGet("books")]
    public async Task<IActionResult> Find(
        [FromQuery] GetBooksRequest request
    )
    {
        if (request.Limit <= 0) {
            return BadRequest("Limit must be provided");
        }

        GetBooksResponse response = await _getBooks.Handle(request);

        return Ok(response.Books);
    }
}
