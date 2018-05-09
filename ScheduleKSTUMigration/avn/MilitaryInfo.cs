namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MilitaryInfo")]
    public partial class MilitaryInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_militaryInfo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        public bool MilitaryTicket { get; set; }

        [StringLength(25)]
        public string NumberMT { get; set; }

        public bool? IsReadyToMS { get; set; }

        [StringLength(10)]
        public string DateMAccount { get; set; }

        public bool? ServiceOrStock { get; set; }

        [StringLength(25)]
        public string Rank { get; set; }

        [StringLength(25)]
        public string MilitaryAcSP { get; set; }

        public int? NumMilSP { get; set; }

        [StringLength(25)]
        public string NameMilComm { get; set; }

        public bool? ConsistsOnAc { get; set; }

        public int? NumberSAc { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual Student Student { get; set; }
    }
}
