using teste.Domain.Entities;

namespace teste.Domain.Repositories;

public interface IBookRepository
{
    Task<ICollection<Book>> List(int limit);
    Task Create(Book book);
}
