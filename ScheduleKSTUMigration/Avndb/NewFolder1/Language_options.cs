namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Language_options
    {
        [Key]
        public int id_lang_options { get; set; }

        public int? id_lang { get; set; }

        public int? id_level { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? id_level_read { get; set; }

        public int? id_level_speak { get; set; }

        public int? id_level_write { get; set; }

        public virtual language1 language { get; set; }

        public virtual Level Level { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
