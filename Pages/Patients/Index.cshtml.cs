using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salud.Web.App.Data;
using Salud.Web.App.Models;
using Salud.Web.App.Services;

namespace Salud.Web.App.Pages.Patients
{
    public class IndexModel : PageModel
    {
        private readonly Salud.Web.App.Data.SaludWebAppContext _context;
        private readonly ServicesPatients _servicesPatients;

        public IndexModel(Salud.Web.App.Data.SaludWebAppContext context )
        {
            _context = context;
           
        }

      
        public IList<Patient> Patient { get;set; }
        
        public async Task OnGetAsync()
            
        {
            Patient = await _context.Patients.ToListAsync();
           
        }
    }
}
