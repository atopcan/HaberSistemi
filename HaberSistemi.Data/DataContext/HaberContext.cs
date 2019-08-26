using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using HaberSistemi.Data.Model;

namespace HaberSistemi.Data.DataContext
{
   public class HaberContext:DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; } // tablo oluşturma
        public DbSet<Rol> Rol { get; set; }
    }
}
