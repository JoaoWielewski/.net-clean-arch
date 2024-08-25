using System;
using teste.Domain.Entities;

namespace teste.Domain.UseCases;

public record CreateBookRequest
{
    public required string Name {get; set; }
    public required string Description {get; set; }
}

public record CreateBookResponse
{
    public required Book Book {get; set; }
}

public interface ICreateBook
{
    Task<CreateBookResponse> Handle(CreateBookRequest request);
}
