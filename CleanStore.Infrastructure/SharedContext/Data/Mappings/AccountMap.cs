using CleanStore.Domain.AccountContext.Entities;
using CleanStore.Domain.AccountContext.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanStore.Infrastructure.SharedContext.Data.Mappings
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            #region Table e PK
            builder.ToTable("Account");

            builder.HasKey(x => x.Id)
                .HasName("PK_Account");

            #endregion

            #region Columns
            builder.OwnsOne(x => x.Email, email =>
            {
                email.HasIndex(e => e.Address)
                        .HasDatabaseName("IX_Account_Email")
                        .IsUnique();

                email.Property(e => e.Address)
                    .HasColumnName("Email")
                    .HasMaxLength(Email.MaxLength)
                    .IsRequired()
                    .HasColumnType("varchar");

                email.Property(e => e.Hash)
                    .HasColumnName("EmailHash")
                    .HasMaxLength(255)
                    .IsRequired()
                    .HasColumnType("varchar");
            });

            #endregion
        }
    }
}
