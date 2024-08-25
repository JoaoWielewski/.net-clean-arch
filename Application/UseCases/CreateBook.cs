using System;
using teste.Domain.Entities;
using teste.Domain.Repositories;
using teste.Domain.UseCases;

namespace teste.Application.UseCases;

public class CreateBook : ICreateBook
{
    private readonly IBookRepository _bookRepository;

    public CreateBook(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<CreateBookResponse> Handle(CreateBookRequest request)
    {
        Guid guid = Guid.NewGuid();

        Book book = new(guid.ToString(), request.Name, request.Description);

        await _bookRepository.Create(book);

        return new CreateBookResponse()
        {
            Book = book
        };
    }
}
