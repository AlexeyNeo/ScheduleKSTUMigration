namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Propiska
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        public int? id_group { get; set; }

        [StringLength(50)]
        public string p20 { get; set; }

        public int? id_student { get; set; }

        [StringLength(70)]
        public string s_fio { get; set; }

        public int? vostast { get; set; }

        public int? id_bk { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Male { get; set; }

        public int? id_republics { get; set; }

        [StringLength(50)]
        public string republic { get; set; }

        public int? IDRegion { get; set; }

        [StringLength(25)]
        public string NameRegion { get; set; }

        public int? IDDistrict { get; set; }

        [StringLength(25)]
        public string NameDistrict { get; set; }

        public int? IDCity { get; set; }

        [StringLength(25)]
        public string NameCity { get; set; }

        public int? IDVillage { get; set; }

        [StringLength(25)]
        public string NameVillage { get; set; }

        [StringLength(400)]
        public string StreetHomeAddress { get; set; }
    }
}
