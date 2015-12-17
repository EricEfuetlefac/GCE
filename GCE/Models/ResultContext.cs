using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GCE.Models
{
    public class ResultContext : DbContext
    {
        public DbSet<GCEresult> GCEresults { get; set; }
    }
}