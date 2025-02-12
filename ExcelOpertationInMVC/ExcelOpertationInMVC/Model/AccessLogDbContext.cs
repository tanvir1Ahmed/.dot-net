using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExcelOpertationInMVC.Model
{
    public class AccessLogDbContext:DbContext
    {
        public DbSet<AccessLog> AccessLogs { get; set; }
    }
}