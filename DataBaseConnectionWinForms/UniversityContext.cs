using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnectionWinForms
{
    class UniversityContext : DbContext
    {
        public UniversityContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set; }    //Студенты
        public DbSet<Teacher> Teachers { get; set; }    //Преподы
        public DbSet<RostRum> RostRums { get; set; }    //Кафедры
    }
}
