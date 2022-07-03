using Microsoft.EntityFrameworkCore;

namespace Descartes.Persistence
{
    public class DescartesContext : DbContext
    {
        public DbSet<Data> DataInserts { get; set; }
        public DbSet<DataPair> DataPairs { get; set; }

        public DescartesContext()
        {

        }

        public DescartesContext(DbContextOptions<DescartesContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           var dataEntity = modelBuilder.Entity<Data>();

            dataEntity.HasKey(de => de.Id);

            dataEntity.HasMany(de => de.PairedToAsFirst)
                .WithOne(dpe => dpe.First)
                .OnDelete(DeleteBehavior.NoAction);
            dataEntity.HasMany(de => de.PairedToAsSecond)
                .WithOne(dpe => dpe.Second)
                .OnDelete(DeleteBehavior.NoAction);

            dataEntity.Property(de => de.Content)
                .IsRequired();
            dataEntity.Property(de => de.Position)
                .IsRequired();

           var dataPairEntity = modelBuilder.Entity<DataPair>();

        }
    }
}
