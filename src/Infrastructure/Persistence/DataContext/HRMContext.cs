namespace Infrastructure.Persistence.DataContext;
public class HRMContext : IdentityDbContext<ApplicationUser>
{
    public HRMContext(DbContextOptions<HRMContext> options) : base(options)
    {

    }
    //public DbSet<TempGLEntry> TempGLEntries { get; set; } = null!;
    //public DbSet<GLReference> GLReferences { get; set; } = null!;
    //public DbSet<GLTransaction> GLTransactions { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //modelBuilder.Entity<GLTransaction>().HasKey(t => t.TransactionId);
        //modelBuilder.Entity<GLReference>().HasKey(t => t.GLReferenceId);
        //modelBuilder.Entity<TempGLEntry>().HasKey(t => t.TransactionId);

        //// These table will not be created in databse. Use for stats only
        //modelBuilder.Entity<VouchersStatsDto>().HasNoKey();
        //modelBuilder.Entity<BaseDomainEntity>().HasNoKey();

        // Identity Table Name Configuration

        modelBuilder.Entity<ApplicationUser>(b => b.ToTable("Users"));
        modelBuilder.Entity<IdentityUserClaim<string>>(b => b.ToTable("UserClaims"));
        modelBuilder.Entity<IdentityUserLogin<string>>(b => b.ToTable("UserLogins"));
        modelBuilder.Entity<IdentityUserToken<string>>(b => b.ToTable("UserTokens"));
        modelBuilder.Entity<IdentityRole>(b => b.ToTable("Roles"));
        modelBuilder.Entity<IdentityRoleClaim<string>>(b => b.ToTable("RoleClaims"));
        modelBuilder.Entity<IdentityUserRole<string>>(b => b.ToTable("UserRoles"));
    }

    //public DbSet<TempGLEntry> TempGLEntries { get; set; } = null!;
    //public DbSet<GLReference> GLReferences { get; set; } = null!;
    //public DbSet<GLTransaction> GLTransactions { get; set; } = null!;

}