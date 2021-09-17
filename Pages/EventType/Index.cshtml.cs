using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SduCyberForm.Models;

namespace SduCyberForm.Pages.EventType
{
    public class IndexModel : PageModel
    {
        private readonly SCFDbContext _db;

        public IndexModel(SCFDbContext db)
        {
            _db = db;
        }

        public IEnumerable<CyberForm> CyberForms { get; set; }
        public IEnumerable<EventTypeModel> EventTypeModels { get; set; }

        public async Task OnGet()
        {
            CyberForms = await _db.CyberForm.ToListAsync();
            EventTypeModels = await _db.EventTypeModel.ToListAsync();
        }
    }
}
