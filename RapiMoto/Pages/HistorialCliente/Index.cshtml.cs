using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RapiMoto.Models;

using Microsoft.AspNetCore.Authorization;

namespace RapiMoto.Pages_HistorialCliente
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTecnicoContext _context;

        public IndexModel(RazorPagesTecnicoContext context)
        {
            _context = context;
        }

        public IList<HistorialCliente> HistorialCliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.HistorialCliente != null)
            {
                HistorialCliente = await _context.HistorialCliente.ToListAsync();
            }
        }
    }
}
