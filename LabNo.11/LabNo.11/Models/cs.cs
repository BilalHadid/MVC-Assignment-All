using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LabNo._11.Models
{
    public class cs:DbContext
    {
        public DbSet<student> students { get; set; }
    }
}