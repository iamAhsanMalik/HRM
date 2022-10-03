namespace Infrastructure.Persistence.Configurations;
internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(t => t.FirstName).HasMaxLength(255);
        builder.Property(t => t.LastName).HasMaxLength(255);
        builder.Property(t => t.Status);
        builder.Property(t => t.Address).HasMaxLength(255);
        builder.Property(t => t.City).HasMaxLength(255);
        builder.Property(t => t.State).HasMaxLength(56);
        builder.Property(t => t.Country).HasMaxLength(56);
        builder.Property(t => t.Zip).HasMaxLength(15);
    }
}
