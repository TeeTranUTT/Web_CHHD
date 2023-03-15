namespace CHHDBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoNew")]
    public partial class InfoNew
    {
        public long Id { get; set; }

        public int? InfoCategoryId { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public string NewContent { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateAt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdateAt { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public long? ViewNumber { get; set; }

        public string ConverURL { get; set; }

        [StringLength(50)]
        public string UpdateTimline { get; set; }

        public int? Status { get; set; }

        public string UrlFile { get; set; }
    }
}
