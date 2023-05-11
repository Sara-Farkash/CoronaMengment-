using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Database:DbContext
    {

        public Database()
        {
        }

        public Database(DbContextOptions<Database> options)
            : base(options)
        {

        }

        public virtual DbSet<User1> Users { get; set; }
        public virtual DbSet<Ill> Ills { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                try{
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-E9M6GFI;Initial Catalog=CoronaManagementDBnew;Integrated Security=True;TrustServerCertificate=True");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

        }








    }
}
