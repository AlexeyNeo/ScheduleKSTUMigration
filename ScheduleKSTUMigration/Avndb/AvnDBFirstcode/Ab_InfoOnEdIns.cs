namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ab_InfoOnEdIns
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_InfoOnEdIns { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        public int? id_learn_lang { get; set; }

        public int? CallEdIns { get; set; }

        public int? TypeScholl { get; set; }

        public bool? SertRespTest { get; set; }

        [StringLength(25)]
        public string NumberSertRT { get; set; }

        public int? BallOnRepsTest { get; set; }

        [StringLength(10)]
        public string YearTerminations { get; set; }

        public bool? OnExcellent { get; set; }

        public bool? WithMedal { get; set; }

        public bool? PrizeOfOlympiad { get; set; }

        public bool? Atestat { get; set; }

        [StringLength(25)]
        public string SeriesAD { get; set; }

        [StringLength(25)]
        public string NumberAD { get; set; }

        public bool? ADOriginal { get; set; }

        public int? LanguageEduc { get; set; }

        public int? PlaseSertORT { get; set; }

        public int? OtherBallORT { get; set; }

        public int TourORT { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(20)]
        public string AVN_User_Update { get; set; }

        public int? ORT_biology { get; set; }

        public int? ORT_history { get; set; }

        public int? ORT_chemistry { get; set; }

        public int? ORT_physics { get; set; }

        public int? ORT_english { get; set; }

        public int? ORT_math { get; set; }

        public virtual CallEducationInst CallEducationInst { get; set; }
    }
}
