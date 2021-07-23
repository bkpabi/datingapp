using DatingApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApplication.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initialize the DataContext class.
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Represts a table in the database
        /// </summary>
        public DbSet<AppUser> Users { get; set; }
    }
}
