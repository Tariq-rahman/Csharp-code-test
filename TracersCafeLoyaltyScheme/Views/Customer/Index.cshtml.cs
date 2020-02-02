using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TracersCafeLoyaltyScheme.Data;
using TracersCafeLoyaltyScheme.Models;

namespace TracersCafeLoyaltyScheme.Views
{
    public class IndexModel : PageModel
    {
        private readonly TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext _context;

        public IndexModel(TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
