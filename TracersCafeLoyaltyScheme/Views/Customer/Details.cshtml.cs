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
    public class DetailsModel : PageModel
    {
        private readonly TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext _context;

        public DetailsModel(TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
