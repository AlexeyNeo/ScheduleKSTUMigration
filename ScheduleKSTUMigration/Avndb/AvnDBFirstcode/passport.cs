namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("passport")]
    public partial class passport
    {
        [Key]
        public int id_pasport { get; set; }

        public int id_teacher { get; set; }

        public int? id_passport_organ { get; set; }

        [StringLength(15)]
        public string s_p { get; set; }

        [StringLength(15)]
        public string n_p { get; set; }

        public DateTime? D_given_p { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(14)]
        public string INN { get; set; }

        public bool? BessrochnyiPasport { get; set; }

        public virtual MVD_Pasport MVD_Pasport { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
