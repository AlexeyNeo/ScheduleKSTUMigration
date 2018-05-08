namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment2V
    {
        public int? id_student { get; set; }

        [Key]
        [Column(Order = 0)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }

        [StringLength(100)]
        public string p104 { get; set; }

        [StringLength(40)]
        public string p105 { get; set; }

        [StringLength(10)]
        public string p32 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [StringLength(80)]
        public string uslugi { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_AVN_user { get; set; }

        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_payment { get; set; }

        public double? p102NewSpec { get; set; }

        public int? id_newSpecP102 { get; set; }

        public int? id_newYear { get; set; }

        public int? id_newRate { get; set; }

        public int? id_newGroup { get; set; }
    }
}
