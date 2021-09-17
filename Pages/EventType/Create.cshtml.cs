using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SduCyberForm.Models;

namespace SduCyberForm.Pages.EventType
{
    public class CreateModel : PageModel
    {
        private readonly SCFDbContext _db;
        public CreateModel(SCFDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public CyberForm CyberForm { get; set; }

        [BindProperty]
        public EventTypeModel EventTypeModel { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.EventTypeModel.AddAsync(EventTypeModel);                           
                await _db.CyberForm.AddAsync(CyberForm);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
