//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDaiLy.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTBAOCAODOANHSO
    {
        public string MaCTBCDS { get; set; }
        public string MaBCDS { get; set; }
        public string MaLoaiHang { get; set; }
        public double TriGia { get; set; }
        public double TiLe { get; set; }
    
        public virtual BAOCAODOANHSO BAOCAODOANHSO { get; set; }
        public virtual LOAIMATHANG LOAIMATHANG { get; set; }
        public virtual LOAIMATHANG LOAIMATHANG1 { get; set; }
    }
}
