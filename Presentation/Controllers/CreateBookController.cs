using System;
using Microsoft.AspNetCore.Mvc;
using teste.Domain.UseCases;

namespace teste.Presentation.Controllers
{
    [Route("book")]
    [ApiController]
    public class CreateBookController : ControllerBase
    {
        private readonly ICreateBook _createBook;

        public CreateBookController(ICreateBook createBook)
        {
            _createBook = createBook;
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromQuery] CreateBookRequest request
        )
        {
            CreateBookResponse response = await _createBook.Handle(request);

            return new CreatedResult("/book", response.Book);
        }
    }
}