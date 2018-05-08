namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class a1_1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(25)]
        public string p19 { get; set; }

        [Column("p6-1")]
        [StringLength(25)]
        public string p6_1 { get; set; }

        [Column("p6-2")]
        [StringLength(25)]
        public string p6_2 { get; set; }

        [Column("p6-3")]
        [StringLength(25)]
        public string p6_3 { get; set; }

        [Column("p6-4")]
        public DateTime? p6_4 { get; set; }

        [StringLength(16)]
        public string p9 { get; set; }

        public DateTime? date_birth { get; set; }

        [StringLength(50)]
        public string k0 { get; set; }

        [StringLength(25)]
        public string k1 { get; set; }

        [StringLength(25)]
        public string k2 { get; set; }

        [StringLength(25)]
        public string k3 { get; set; }

        [StringLength(25)]
        public string k4 { get; set; }

        [StringLength(50)]
        public string regRep { get; set; }

        [StringLength(25)]
        public string regReg { get; set; }

        [StringLength(25)]
        public string regDist { get; set; }

        [StringLength(25)]
        public string regCity { get; set; }

        [StringLength(25)]
        public string regVil { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [StringLength(400)]
        public string StreetHomeAddress { get; set; }

        [StringLength(400)]
        public string Streetbirth { get; set; }

        public int? id_republicHome { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionHomeAddress { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionBirth { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistrictHomeAddress { get; set; }

        [StringLength(50)]
        public string repnow { get; set; }

        [StringLength(25)]
        public string regnow { get; set; }

        [StringLength(25)]
        public string distnow { get; set; }

        [StringLength(25)]
        public string citynow { get; set; }

        [StringLength(25)]
        public string vilnow { get; set; }

        [StringLength(400)]
        public string strnow { get; set; }

        public int? id_republics { get; set; }
    }
}
