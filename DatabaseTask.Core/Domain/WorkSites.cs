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

    public class WorkSitesContext : DbContext
    {
        public DbSet<WorkSites> WorkSites { get; set; }
    }
    public class WorkSites
    {
        [Key]
        public Guid WorkSiteId { get; set; }
        public  ConstructionCompany ProjectId { get; set; }
        public Projects CompletionTime { get; set; }
        public Employees EmployeeId { get; set; }
        public Employees FirstName { get; set; }
        public Employees? Specialistation { get; set; }
    }
}
