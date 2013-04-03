using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BookMeInAllInOne.Web.Models.Mapping
{
    public class SiteMap : EntityTypeConfiguration<Site>
    {
        public SiteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SiteId, t.SiteName });

            // Properties
            this.Property(t => t.SiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SiteName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Site");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
        }
    }
}
