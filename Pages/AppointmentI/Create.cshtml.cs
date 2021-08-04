using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Salud.Web.App.Data;
using Salud.Web.App.Models;

namespace Salud.Web.App.Pages.AppointmentI
{
    public class CreateModel : PageModel
    {
        private readonly Salud.Web.App.Data.SaludWebAppContext _context;

        public CreateModel(Salud.Web.App.Data.SaludWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountDoctorId"] = new SelectList(_context.AspNetUsers, "Id", "Id");
        ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "City");
            return Page();
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointments.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
