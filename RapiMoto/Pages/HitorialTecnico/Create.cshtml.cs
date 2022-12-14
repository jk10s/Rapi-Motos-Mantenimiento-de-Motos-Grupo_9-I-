using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RapiMoto.Models;

using Microsoft.AspNetCore.Authorization;

namespace RapiMoto.Pages_HitorialTecnico
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly RazorPagesTecnicoContext _context;

        public CreateModel(RazorPagesTecnicoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HitorialTecnico HitorialTecnico { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.HitorialTecnico == null || HitorialTecnico == null)
            {
                return Page();
            }

            _context.HitorialTecnico.Add(HitorialTecnico);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
