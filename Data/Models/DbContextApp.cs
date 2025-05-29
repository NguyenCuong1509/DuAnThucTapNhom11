using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DbContextApp : DbContext
    {
        public DbContextApp()
        {
            
        }

        public DbContextApp(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=DuanNhom11;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<DiaChiKhachHang> DiaChiKhachHangs { get; set; }
       

    }
}
