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
        public DbSet<Worksites> WorkSites { get; set; }
    }
    public class Worksites
    {
        

        [Key]
        public Guid WorkSiteId { get; set; }
        public  Projects ProjectId { get; set; }
        public DateTime CompletionTime { get; set; }
        public string Location { get; set; }
        public string Equipment { get; set; }
        public int EmployeesNeeded { get; set; }

    }
}
