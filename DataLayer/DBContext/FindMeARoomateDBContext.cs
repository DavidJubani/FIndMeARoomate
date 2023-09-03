using FIndMeARoomate.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using FIndMeARoomate.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomate.DataLayer.DBContext
{

    public class FindMeARoomateDBContext: Microsoft.EntityFrameworkCore.DbContext 
    {
        public FindMeARoomateDBContext() { }
        public FindMeARoomateDBContext(DbContextOptions<FindMeARoomateDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<DormitoryStudent> DormitoryStudents { get; set; } = default!;
        public DbSet<Dormitory> Dormitory { get; set; } = default!;
        public DbSet<Anouncement> Anouncement { get; set; } = default!;
        public DbSet<Applications> Applications { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2459B7G\SQLEXPRESS01; Initial Catalog=Dormitory;Integrated Security=True;TrustServerCertificate=True");
        }

    }
    
}
