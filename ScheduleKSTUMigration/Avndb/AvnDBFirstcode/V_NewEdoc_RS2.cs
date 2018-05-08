namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_NewEdoc_RS2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_movementDoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_doc { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_movementDocStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string movementDocStatus { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_userFrom_groupFrom { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_userFrom { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_userTo { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_movementType { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string movementType { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime startDate { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime endDate { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime created { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime updated { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool isAcceptedOriginalDoc { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(295)]
        public string avtor { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(200)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_userTo_GroupFrom { get; set; }

        [Key]
        [Column(Order = 17)]
        public string docContent { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(500)]
        public string docFromInfo { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(2050)]
        public string fromDetails { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(100)]
        public string regNum { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(100)]
        public string docNum { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(100)]
        public string docStatus { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime registered { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool isResponsible { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(500)]
        public string namefromInfoCategory { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_fromInfoCategory { get; set; }

        [Key]
        [Column(Order = 27)]
        public DateTime finish { get; set; }

        [Key]
        [Column(Order = 28)]
        public DateTime completed { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_docStatusAction { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_docTask { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(295)]
        public string snp { get; set; }
    }
}
