namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_NewEdoc_RS1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(295)]
        public string snp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_language { get; set; }
    }
}
