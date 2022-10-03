//namespace Infrastructure.Persistence.Configurations;
//internal class GLTransactionConfiguration : IEntityTypeConfiguration<GLTransaction>
//{
//    public void Configure(EntityTypeBuilder<GLTransaction> builder)
//    {
//        builder.Property(t => t.TransactionId).UseIdentityColumn().IsRequired();
//        builder.Property(t => t.GLReferenceId);
//        builder.Property(t => t.AccountTypeiCode).HasMaxLength(20);
//        builder.Property(t => t.AccountCode).HasMaxLength(50).IsRequired();
//        builder.Property(t => t.Memorandum).HasMaxLength(250);
//        builder.Property(t => t.ForeignCurrencyISOCode).HasMaxLength(3);
//        builder.Property(t => t.ForeignCurrencyAmount).HasPrecision(18, 4);
//        builder.Property(t => t.LocalCurrencyISOCode).HasMaxLength(3);
//        builder.Property(t => t.LocalCurrencyAmount).HasPrecision(18, 4);
//        builder.Property(t => t.ExchangeRate).HasPrecision(18, 4);
//        builder.Property(t => t.Payee).HasMaxLength(150);
//        builder.Property(t => t.Customer).HasMaxLength(150);
//        builder.Property(t => t.TransactionNumber).HasMaxLength(20);
//        builder.Property(t => t.InstrumentNumber).HasMaxLength(150);
//        builder.Property(t => t.CreatedBy).HasMaxLength(450);
//        builder.Property(t => t.Created);
//        builder.Property(t => t.LastModified).HasMaxLength(50);
//        builder.Property(t => t.LastModifyBy).HasMaxLength(450);
//    }
//}
