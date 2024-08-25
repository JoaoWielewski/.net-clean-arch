using System;
using Microsoft.EntityFrameworkCore;
using teste.Domain.Entities;
using teste.Domain.Repositories;
using teste.Infra.Db;

namespace teste.Infra.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Book>> List(int limit) {
         return await _context.Books.Take(limit).ToListAsync();
    }

    public async Task Create(Book book)
    {
        _context.Add(book);
        await _context.SaveChangesAsync();
    }
}
