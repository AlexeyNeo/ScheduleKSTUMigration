//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleKSTUMigration.Avndb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vakansii
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vakansii()
        {
            this.Working = new HashSet<Working>();
        }
    
        public int id_vakansiya { get; set; }
        public Nullable<int> id_otdel_1 { get; set; }
        public Nullable<int> id_otdel_11 { get; set; }
        public Nullable<int> id_faculty { get; set; }
        public Nullable<int> id_otdel_2 { get; set; }
        public Nullable<int> id_kafedra { get; set; }
        public int id_structure { get; set; }
        public int id_bk { get; set; }
        public int id_post { get; set; }
        public float q_units { get; set; }
        public decimal razrad { get; set; }
        public Nullable<int> Num { get; set; }
        public int id_enter { get; set; }
        public string e_n_p { get; set; }
        public Nullable<System.DateTime> e_d_p { get; set; }
        public int id_deduce { get; set; }
        public string d_n_p { get; set; }
        public Nullable<System.DateTime> d_d_p { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public Nullable<double> hourFond { get; set; }
        public string descr { get; set; }
        public Nullable<int> id_o_z { get; set; }
    
        public virtual deduce deduce { get; set; }
        public virtual enter enter { get; set; }
        public virtual Otdel_1 Otdel_1 { get; set; }
        public virtual Otdel_1 Otdel_11 { get; set; }
        public virtual Otdel_1 Otdel_12 { get; set; }
        public virtual post post { get; set; }
        public virtual structure structure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Working> Working { get; set; }
    }
}