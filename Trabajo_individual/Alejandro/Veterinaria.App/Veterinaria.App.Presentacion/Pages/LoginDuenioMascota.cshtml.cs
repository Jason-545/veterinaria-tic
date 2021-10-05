using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
    public class LoginDuenioMascotaModel : PageModel
    {
        private readonly ILogger<LoginDuenioMascotaModel> _logger;

        public LoginDuenioMascotaModel(ILogger<LoginDuenioMascotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
