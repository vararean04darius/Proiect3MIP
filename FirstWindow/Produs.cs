using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstWindow
{
    public class Produs
    {
        [Key]
        public int IdProdus { get; set; }

        [Required]
        public string Denumire { get; set; }

        [Required]
        public int Cantitate { get; set; }
        [Required]
        public int Pret { get; set; }
    }
    public class MagazinDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
    }

}
