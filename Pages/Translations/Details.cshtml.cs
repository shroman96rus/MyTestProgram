using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTestProgram.Data;
using MyTestProgram.Pages.Model;

namespace MyTestProgram.Pages.Translations
{
    public class DetailsModel : PageModel
    {
        private readonly MyTestProgram.Data.MyTestProgramContext _context;

        public DetailsModel(MyTestProgram.Data.MyTestProgramContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaction = await _context.Transaction.FirstOrDefaultAsync(m => m.ID == id);

            if (Transaction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
