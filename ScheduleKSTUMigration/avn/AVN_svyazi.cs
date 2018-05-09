namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_svyazi
    {
        [Key]
        public int id_AVN_svyazi { get; set; }

        [StringLength(50)]
        public string vopros { get; set; }

        [StringLength(50)]
        public string osn_table_name { get; set; }

        [StringLength(50)]
        public string osn_ident_name { get; set; }

        [StringLength(50)]
        public string dop_table_name { get; set; }

        [StringLength(50)]
        public string dop_ident_name { get; set; }

        public bool isHandled { get; set; }

        public int dop_table_from_id { get; set; }

        public int rows { get; set; }

        public int affected { get; set; }

        public int order { get; set; }
    }
}
