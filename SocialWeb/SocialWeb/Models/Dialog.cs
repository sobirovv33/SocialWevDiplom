//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dialog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dialog()
        {
            this.DialogMessage = new HashSet<DialogMessage>();
            this.DialogUsers = new HashSet<DialogUsers>();
        }
    
        public int idDialog { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdType { get; set; }
    
        public virtual DialogType DialogType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DialogMessage> DialogMessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DialogUsers> DialogUsers { get; set; }
    }
}
