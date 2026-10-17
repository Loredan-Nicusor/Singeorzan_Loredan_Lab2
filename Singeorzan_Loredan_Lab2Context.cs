using Microsoft.EntityFrameworkCore;

public class Singeorzan_Loredan_Lab2Context(DbContextOptions<Singeorzan_Loredan_Lab2Context> options) : DbContext(options)
{
    public DbSet<Singeorzan_Loredan_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Author> Author { get; set; } = default!;
}
