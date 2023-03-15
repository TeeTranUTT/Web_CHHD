namespace CHHDBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoMedia")]
    public partial class InfoMedia
    {
        public long Id { get; set; }

        public int? InfoMediaListId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string MediaContent { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateAt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdateAt { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public long? ViewNumber { get; set; }

        [StringLength(50)]
        public string UpdatedTimeline { get; set; }

        public int? Status { get; set; }

        public bool? TypeURL { get; set; }
    }
}
