namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_elements
    {
        [Key]
        public int id_rrnk_elements { get; set; }

        [Required]
        [StringLength(50)]
        public string r_element { get; set; }

        [StringLength(50)]
        public string n_element { get; set; }

        public bool? visible { get; set; }

        public int? order_pole { get; set; }

        [StringLength(100)]
        public string formula { get; set; }

        [StringLength(50)]
        public string short_n_element { get; set; }
    }
}
