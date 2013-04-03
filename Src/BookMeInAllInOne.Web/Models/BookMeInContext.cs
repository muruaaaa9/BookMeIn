using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BookMeInAllInOne.Web.Models.Mapping;

namespace BookMeInAllInOne.Web.Models
{
    public class BookMeInContext : DbContext
    {
        static BookMeInContext()
        {
            Database.SetInitializer<BookMeInContext>(null);
        }

		public BookMeInContext()
			: base("Name=BookMeInContext")
		{
		}

        public DbSet<Site> Sites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SiteMap());
        }
    }
}
