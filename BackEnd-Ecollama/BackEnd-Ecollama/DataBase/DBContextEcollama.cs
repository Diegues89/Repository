using BackEnd_Ecollama.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Ecollama.DataBase
{
    public class DBContextEcollama: DbContext

    {
        public DBContextEcollama(DbContextOptions<DBContextEcollama> options)
            : base(options)
        {

        }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }

        public virtual DbSet<Venta> Venta { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Productos>(entity =>
            {

                entity.ToTable("Productos", "dbo");

            });
            modelBuilder.Entity<Clientes>(entity =>
            {

                entity.ToTable("Clientes", "dbo");

            });
            modelBuilder.Entity<Venta>(entity =>
            {

                entity.ToTable("Ventas", "dbo");

            });

            modelBuilder.Entity<VentasDetalle>().ToSqlQuery("Exec dbo.ReporteVentas");


        }
    }
}
