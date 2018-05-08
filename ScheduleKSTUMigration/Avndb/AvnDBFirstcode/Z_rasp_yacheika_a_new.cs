namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_rasp_yacheika_a_new
    {
        public int? id_a_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_faculty { get; set; }

        public int? id_speciality { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        public int? id_discipline { get; set; }

        public int? kredit { get; set; }

        public int? id_teacher { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? b_num_nedeli { get; set; }

        public int? e_num_nedeli { get; set; }

        public int? id_group { get; set; }

        public int? id_time { get; set; }

        public int? day_number { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ch_zn { get; set; }

        public byte? rrnkType { get; set; }
    }
}
