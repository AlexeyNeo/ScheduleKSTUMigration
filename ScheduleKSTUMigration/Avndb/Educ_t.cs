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
    
    public partial class Educ_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Educ_t()
        {
            this.Educ = new HashSet<Educ>();
        }
    
        public int id_educ_t { get; set; }
        public string Educ_type { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Educ> Educ { get; set; }
    }
}