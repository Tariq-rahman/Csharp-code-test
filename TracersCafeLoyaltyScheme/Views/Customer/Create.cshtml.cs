using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TracersCafeLoyaltyScheme.Data;
using TracersCafeLoyaltyScheme.Models;

namespace TracersCafeLoyaltyScheme.Views
{
    public class CreateModel : PageModel
    {
        private readonly TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext _context;

        public CreateModel(TracersCafeLoyaltyScheme.Data.TracersCafeLoyaltySchemeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
