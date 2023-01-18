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

    public class ProjectsContext : DbContext
    {
        public DbSet<Projects> Projects { get; set; }
    }

    public class Projects
    {
        [Key]
        public ConstructionCompany ProjectId { get; set; }
        public DateTime CompletionTime { get; set; }
        public string ProjectSiteLocation { get; set; }
        public SqlMoney? Payment { get; set; }
    }

    
}

