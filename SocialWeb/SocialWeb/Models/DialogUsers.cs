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
    
    public partial class DialogUsers
    {
        public int idDialogUser { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idDialog { get; set; }
    
        public virtual Dialog Dialog { get; set; }
        public virtual Users Users { get; set; }
    }
}
