using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    //File : /Models/EmployeeContext.cs
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
