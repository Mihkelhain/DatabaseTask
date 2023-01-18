using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Core.Domain
{

    public class ContstructionCompanyContext : DbContext
    {
        public DbSet<ConstructionCompany> ConstructionCompany { get; set; }
    }
    public class ConstructionCompany
    {
        [Key]
        public Guid ProjectId { get; set; }

    }

}

