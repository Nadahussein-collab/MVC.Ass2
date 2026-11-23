using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Ass2.Entities;

namespace MVC.Ass2.Configrations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plans>
    {
        void IEntityTypeConfiguration<Plans>.Configure(EntityTypeBuilder<Plans> builder)
        {
            builder.Property(P => P.CreatedAt).HasDefaultValueSql("GETDATE()");


            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_DurationDaysConstraints", "DurationDays Between 1 And 365");
            });
        }
    }
}
