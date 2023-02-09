using Eldorado.TeamManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eldorado.TeamManager.DataAccess.Configurations
{
    public class CollaboratorSkillConfiguration : IEntityTypeConfiguration<CollaboratorSkill>
    {
        public void Configure(EntityTypeBuilder<CollaboratorSkill> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}


