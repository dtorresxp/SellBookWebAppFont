//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TACGIA
    {
        public TACGIA()
        {
            this.SACHes = new HashSet<SACH>();
        }
    
        public string MATG { get; set; }
        public string TENTG { get; set; }
        public string DIACHI { get; set; }
        public string TIEUSU { get; set; }
        public Nullable<int> SDT { get; set; }
    
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
