using MVC.Ass2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MVC.Ass2.Configrations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        void IEntityTypeConfiguration<MemberShip>.Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(M => M.CreatedAt).HasDefaultValueSql("GetDate()");

        }
    }
}
