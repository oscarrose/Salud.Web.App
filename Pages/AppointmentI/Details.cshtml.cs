using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salud.Web.App.Data;
using Salud.Web.App.Models;

namespace Salud.Web.App.Pages.AppointmentI
{
    public class DetailsModel : PageModel
    {
        private readonly Salud.Web.App.Data.SaludWebAppContext _context;

        public DetailsModel(Salud.Web.App.Data.SaludWebAppContext context)
        {
            _context = context;
        }

        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointments
                .Include(a => a.AccountDoctor)
                .Include(a => a.Patient).FirstOrDefaultAsync(m => m.AppointmentId == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
