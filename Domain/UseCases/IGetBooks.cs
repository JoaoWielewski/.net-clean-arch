using System;
using teste.Domain.Entities;

namespace teste.Domain.UseCases;

public record GetBooksRequest
{
    public required int Limit {get; set; }
}

public record GetBooksResponse
{
    public required ICollection<Book> Books {get; set; }
}

public interface IGetBooks
{
    Task<GetBooksResponse> Handle(GetBooksRequest request);
}
