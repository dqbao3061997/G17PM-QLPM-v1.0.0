namespace MvcAppMain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [Column(Order = 0)]
        public int ID_HoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PhieuKham { get; set; }

        public int? TienKham { get; set; }

        public int? TienThuoc { get; set; }

        public int? DoanhThu { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
