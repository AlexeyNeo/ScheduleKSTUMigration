namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementView")]
    public partial class MovementView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string come { get; set; }

        [StringLength(40)]
        public string come_reg { get; set; }

        public DateTime? come_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string leave { get; set; }

        [StringLength(40)]
        public string leave_reg { get; set; }

        public DateTime? leave_date { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_leave { get; set; }

        [StringLength(101)]
        public string come_k { get; set; }

        [StringLength(101)]
        public string leave_k { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(53)]
        public string sh_st { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column("p23-1", Order = 9)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }
    }
}
