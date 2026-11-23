using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Ass2.Entities;

namespace MVC.Ass2.Configrations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(T => T.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
