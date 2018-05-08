namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Contragents
    {
        [Key]
        public int id_contragent { get; set; }

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
        [StringLength(50)]
        public string otdel { get; set; }

        [Required]
        [StringLength(50)]
        public string doljnost { get; set; }

        [Required]
        [StringLength(100)]
        public string host { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Column(TypeName = "date")]
        public DateTime avn_update { get; set; }
    }
}
