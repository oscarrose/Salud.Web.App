using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salud.Web.App.Data;
using Salud.Web.App.Models;

namespace Salud.Web.App.Pages.Patients
{
    public class DetailsModel : PageModel
    {
        private readonly Salud.Web.App.Data.SaludWebAppContext _context;

        public DetailsModel(Salud.Web.App.Data.SaludWebAppContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patient = await _context.Patients.FirstOrDefaultAsync(m => m.PatientId == id);

            if (Patient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
