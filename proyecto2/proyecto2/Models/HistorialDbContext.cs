using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace proyecto2.Models
{
    public class HistorialDbContext : DbContext
    {
        public HistorialDbContext() : base("name=DefaultConnection")
        {
        }
        


    }
}
