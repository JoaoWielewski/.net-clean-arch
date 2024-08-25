using System;
using teste.Domain.Entities;
using teste.Domain.Repositories;
using teste.Domain.UseCases;

namespace teste.Application.UseCases;

public class GetBooks : IGetBooks
{
    private readonly IBookRepository _bookRepository;

    public GetBooks(IBookRepository bookRepository) {
        _bookRepository = bookRepository;
    }

    public async Task<GetBooksResponse> Handle(GetBooksRequest request)
    {
        return new GetBooksResponse() {
            Books = await _bookRepository.List(request.Limit)
        };
    }
}
