using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CHHDBase
{
    public partial class CHHDDbContext : DbContext
    {
        public CHHDDbContext()
            : base("name=CHHDDbContext")
        {
        }

        public DbSet<ImagePage> ImagePages { get; set; }
        public DbSet<InfoCategory> InfoCategorie { get; set; }
        public DbSet<InfoFooter> InfoFooter { get; set; }
        public DbSet<InfoMedia> InfoMedia { get; set; }
        public DbSet<InfoMediaList> InfoMediaList { get; set; }
        public DbSet<InfoNew> InfoNew { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        [Table("ImagePage")]
        public partial class ImagePage
        {
            public int Id { get; set; }

            public string PageName { get; set; }

            public string Page { get; set; }
            public string Location { get; set; }

            public string Image { get; set; }

            public bool? Status { get; set; }

            public string Description { get; set; }

            public string Title { get; set; }

            public DateTime? CreateDate { get; set; }
        }
    }
}
