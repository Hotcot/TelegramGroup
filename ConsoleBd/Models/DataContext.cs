namespace ConsoleBd
{

    using System.Data.Entity;
 

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ClassData> ClassData { get; set; }
        public virtual DbSet<IndificatorData> IndificatorData { get; set; }
        public virtual DbSet<LogData> LogData { get; set; }
        public virtual DbSet<ParsData> ParsData { get; set; }
        public virtual DbSet<TegsData> TegsData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
