using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Singeorzan_Loredan_Lab2.Models;

namespace Singeorzan_Loredan_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Singeorzan_Loredan_Lab2Context _context;

    public IndexModel(Singeorzan_Loredan_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book
            .Include(b => b.Publisher)
            .Include(b => b.Author)
            .ToListAsync();
    }
}
