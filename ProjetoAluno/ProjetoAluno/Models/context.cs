using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoAluno.Models
{
    public class context: DbContext
    {
        public DbSet<pessoa> Pessoas { get; set; }
    }
}