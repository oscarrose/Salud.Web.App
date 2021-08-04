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
    public class IndexModel : PageModel
    {
        private readonly Salud.Web.App.Data.SaludWebAppContext _context;

        public IndexModel(Salud.Web.App.Data.SaludWebAppContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointments
                .Include(a => a.AccountDoctor)
                .Include(a => a.Patient).ToListAsync();
        }
    }
}
