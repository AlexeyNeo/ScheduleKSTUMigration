namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoSchool")]
    public partial class InfoSchool
    {
        [StringLength(25)]
        public string NameCity { get; set; }

        [StringLength(25)]
        public string NameDistrict { get; set; }

        [StringLength(25)]
        public string NameRegion { get; set; }

        [StringLength(25)]
        public string NameVillage { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CallEducat { get; set; }

        [StringLength(25)]
        public string NameEdInst { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCall { get; set; }

        public int? IDRegion { get; set; }

        public int? IDVillage { get; set; }

        public int? IDType { get; set; }

        public int? IDDistrict { get; set; }

        public int? IDCity { get; set; }

        [StringLength(50)]
        public string republic { get; set; }
    }
}
