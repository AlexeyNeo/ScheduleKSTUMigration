namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_User
    {
        [Key]
        [Column(Order = 0)]
        public int id_AVN_user { get; set; }

        public bool visible { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string AVN_login { get; set; }

        [StringLength(32)]
        public string AVN_password { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(200)]
        public string doljnost { get; set; }

        public bool activ { get; set; }

        public int kol_p { get; set; }

        public DateTime? start_dp { get; set; }

        public DateTime? end_dp { get; set; }

        [StringLength(50)]
        public string Old_password { get; set; }

        public byte? type { get; set; }

        public bool? b { get; set; }

        public bool? k { get; set; }

        public int? id_kassa { get; set; }

        public int? passLife { get; set; }

        public int? id_language { get; set; }

        public int? temp { get; set; }

        public bool canUploadUmk { get; set; }

        public bool canChangeDopusk { get; set; }

        public bool canEditAVN38 { get; set; }

        public bool canEditAVN2 { get; set; }

        public bool? canTerminal { get; set; }

        public bool isSmsAdmin { get; set; }

        public bool canRemoveDFSFromExStudent { get; set; }
    }
}
