namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_ORT_balls
    {
        [Key]
        public int id_student_ORT_balls { get; set; }

        public int? id_a_year { get; set; }

        public int? id_student { get; set; }

        public int? tour { get; set; }

        public int? id_bk { get; set; }

        public int? id_faculty { get; set; }

        public int? id_direction { get; set; }

        public int? id_speciality { get; set; }

        [StringLength(100)]
        public string NumberSertRT { get; set; }

        public int? BallOnRepsTest { get; set; }

        public int? ORT_math { get; set; }

        public int? ORT_physics { get; set; }

        public int? ORT_english { get; set; }

        public int? ORT_chemistry { get; set; }

        public int? ORT_history { get; set; }

        public int? ORT_biology { get; set; }
    }
}
