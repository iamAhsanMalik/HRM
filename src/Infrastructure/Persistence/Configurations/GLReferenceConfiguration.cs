//namespace Infrastructure.Persistence.Configurations;
//internal class GLReferenceConfiguration : IEntityTypeConfiguration<GLReference>
//{
//    public void Configure(EntityTypeBuilder<GLReference> builder)
//    {
//        builder.Property(t => t.GLReferenceId).UseIdentityColumn().IsRequired();
//        builder.Property(t => t.AccountTypeiCode).HasMaxLength(20);
//        builder.Property(t => t.Memorandum).HasMaxLength(250);
//        builder.Property(t => t.ReferenceNo).HasMaxLength(50);
//        builder.Property(t => t.IsPosted);
//        builder.Property(t => t.PostedBy).HasMaxLength(450);
//        builder.Property(t => t.PostedDate);
//        builder.Property(t => t.AuthorizedBy).HasMaxLength(450);
//        builder.Property(t => t.AuthorizedDate);
//        builder.Property(t => t.VoucherNumber);
//        builder.Property(t => t.InstrumentNumber).HasMaxLength(150);
//        builder.Property(t => t.CreatedBy).HasMaxLength(450);
//        builder.Property(t => t.Created);
//        builder.Property(t => t.LastModified).HasMaxLength(50);
//        builder.Property(t => t.LastModifyBy).HasMaxLength(450);
//    }
//}
