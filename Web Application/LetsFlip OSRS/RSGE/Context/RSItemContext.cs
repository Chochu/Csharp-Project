using RSGE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RSGE.Context
{
    public class RSItemContext: DbContext
    {
        public DbSet<RSItem> RSItem { get; set; }
    }
}