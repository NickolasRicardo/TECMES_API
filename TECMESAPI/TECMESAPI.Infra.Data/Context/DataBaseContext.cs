using TECMESAPI.Domain.Entities;
using TECMESAPI.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TECMESAPI.Infra.Data.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("Mysql_DB");
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<MaquinaEntity> Maquina { get; set; }
        public DbSet<OrdemProducaoEntity> OrdemProducao { get; set; }
        public DbSet<ProducaoEntity> Producao { get; set; }
        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<VendaEntity> Venda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new MaquinaConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new OrdemProducaoConfig());
            modelBuilder.ApplyConfiguration(new ProducaoConfig());
            modelBuilder.ApplyConfiguration(new VendaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
