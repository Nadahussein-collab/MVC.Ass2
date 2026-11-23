using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Ass2.Entities;



namespace MVC.Ass2.Configrations
{
    public class MemberConfigurations : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        void IEntityTypeConfiguration<Member>.Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(M => M.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
