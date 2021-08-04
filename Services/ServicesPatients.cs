using Salud.Web.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salud.Web.App.Models;
namespace Salud.Web.App.Services
{
    public class ServicesPatients
    {
        private readonly SaludWebAppContext _saludWebAppContext;

        public ServicesPatients( Salud.Web.App.Data.SaludWebAppContext saludWebAppContext) 
        {
            _saludWebAppContext = saludWebAppContext;
        }

      

        public IList<Patient> patients { get; set; }
        public async  Task GetPatientAsybc()
        {
            patients = await _saludWebAppContext.Patients.ToListAsync();
        }

        

    }
}
