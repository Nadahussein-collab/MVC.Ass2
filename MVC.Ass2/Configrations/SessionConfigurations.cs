using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Ass2.Entities;

namespace MVC.Ass2.Configrations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        void IEntityTypeConfiguration<Session>.Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_CapacityConstraint", "Capacity Between 1 And 25");
                X.HasCheckConstraint("ck_StartEndDateConstraint", "EndDate > StartDate");
            });

            builder.HasOne(S => S.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
