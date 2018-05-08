namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uslugi")]
    public partial class uslugi
    {
        [Key]
        public int id_uslug { get; set; }

        [Column("uslugi")]
        [Required]
        [StringLength(80)]
        public string uslugi1 { get; set; }

        public double? proc1 { get; set; }

        public double? proc2 { get; set; }

        public int? id_shet { get; set; }

        [Required]
        [StringLength(50)]
        public string oper { get; set; }

        public DateTime u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public float? procent { get; set; }

        [StringLength(50)]
        public string shet { get; set; }

        public bool? is_visible { get; set; }

        public int? id_kassa { get; set; }

        public int? code_pay { get; set; }

        [Column("short")]
        [StringLength(250)]
        public string _short { get; set; }

        public virtual shet shet1 { get; set; }
    }
}
