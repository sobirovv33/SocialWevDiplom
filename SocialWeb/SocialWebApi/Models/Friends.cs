//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Friends
    {
        public int idFriendship { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idFried { get; set; }
        public Nullable<int> idAppStatus { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public bool isFriend { get; set; }
    
        public virtual ApplicationStatus ApplicationStatus { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}