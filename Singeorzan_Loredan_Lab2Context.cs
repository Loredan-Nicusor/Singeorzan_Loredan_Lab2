using Microsoft.EntityFrameworkCore;
using Singeorzan_Loredan_Lab2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

public class Singeorzan_Loredan_Lab2Context : IdentityDbContext<IdentityUser>
{
    public Singeorzan_Loredan_Lab2Context(DbContextOptions<Singeorzan_Loredan_Lab2Context> options): base(options)
    { }
    public DbSet<Singeorzan_Loredan_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Category> Category { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Member> Member { get; set; } = default!;
    public DbSet<Singeorzan_Loredan_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
}
