using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace quiz1_pbkk.Pages;
public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        return RedirectToPage("q1/Index");
    }
}
