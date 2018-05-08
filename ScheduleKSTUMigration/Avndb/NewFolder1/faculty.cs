namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("faculty")]
    public partial class faculty
    {
        [Key]
        [Column(Order = 0)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [StringLength(50)]
        public string NameFaculty { get; set; }

        public int id_vuz { get; set; }

        public bool? priem_abit { get; set; }

        [Column("p23-2_k")]
        [StringLength(100)]
        public string p23_2_k { get; set; }

        public int? sort { get; set; }

        [StringLength(20)]
        public string id_ua { get; set; }

        [Column("__code")]
        [StringLength(5)]
        public string C__code { get; set; }

        [Column("p23-3")]
        [StringLength(100)]
        public string p23_3 { get; set; }

        [Column("p23-4")]
        [StringLength(100)]
        public string p23_4 { get; set; }

        [StringLength(100)]
        public string n_director { get; set; }

        [StringLength(50)]
        public string stukture { get; set; }

        public int? f_group { get; set; }

        [Column("p23-2-1")]
        [StringLength(100)]
        public string p23_2_1 { get; set; }

        public byte? RS { get; set; }

        [StringLength(100)]
        public string p_komissi { get; set; }

        [StringLength(50)]
        public string doljnost { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public byte? Visible_TV_abit { get; set; }

        public int? RS_opl { get; set; }

        public int? o_z { get; set; }

        public virtual vuz vuz { get; set; }
    }
}
