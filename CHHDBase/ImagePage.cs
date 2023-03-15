using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace CHHDBase
{

    public partial class ImagePageModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string PageName { get; set; }

        [StringLength(50)]
        public string Page { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public bool? Status { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
