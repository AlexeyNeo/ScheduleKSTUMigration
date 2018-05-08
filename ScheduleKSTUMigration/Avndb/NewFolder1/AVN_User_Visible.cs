namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_User_Visible
    {
        [Key]
        [Column(Order = 0)]
        public int id_AVN_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string AVN_login { get; set; }

        [StringLength(32)]
        public string AVN_password { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string surname { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string patronymic { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string doljnost { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool activ { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_p { get; set; }

        public DateTime? start_dp { get; set; }

        public DateTime? end_dp { get; set; }

        [StringLength(50)]
        public string Old_password { get; set; }

        public byte? type { get; set; }

        public bool? b { get; set; }

        public bool? k { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool visible { get; set; }

        public int? id_kassa { get; set; }

        public int? passLife { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool canUploadUmk { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool canChangeDopusk { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool canEditAVN38 { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool canEditAVN2 { get; set; }

        public bool? canTerminal { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool isSmsAdmin { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool canRemoveDFSFromExStudent { get; set; }
    }
}
