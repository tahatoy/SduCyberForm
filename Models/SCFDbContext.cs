using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SduCyberForm.Models
{
    public class SCFDbContext : DbContext
    {
        public SCFDbContext(DbContextOptions<SCFDbContext> options) : base(options)
        {

        }
        public DbSet<CyberForm> CyberForm { get; set; }
        public DbSet<EventTypeModel> EventTypeModel {get;set;}

    }
}
