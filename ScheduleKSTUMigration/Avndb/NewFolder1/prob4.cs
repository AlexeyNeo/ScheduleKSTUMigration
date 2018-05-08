namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prob4
    {
        public int? id_speciality { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [Key]
        [Column(Order = 2)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime p103 { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [StringLength(40)]
        public string p105 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_payment { get; set; }

        public int? id_student { get; set; }
    }
}
