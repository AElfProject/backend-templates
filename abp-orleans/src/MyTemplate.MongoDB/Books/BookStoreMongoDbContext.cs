using MongoDB.Driver;
using MyTemplate.Authors;
using Volo.Abp.MongoDB;

namespace MyTemplate.Books;

public class BookStoreMongoDbContext : AbpMongoDbContext
{
    public IMongoCollection<Book> Books => Collection<Book>();
    public IMongoCollection<Author> Authors => Collection<Author>();

}
