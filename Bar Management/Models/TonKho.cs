using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class TonKho {
        [Key]
        public int Id { get; set; }

        [Required]
        public int NguyenLieuId { get; set; }

        [ForeignKey("NguyenLieuId")]
        public NguyenLieu NguyenLieu { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        [MaxLength(20)]
        public string DonVi { get; set; }

        [Required]
        public decimal GiaNhap { get; set; }

        [DefaultValue(1)]
        public int TrangThaiId { get; set; }

        [ForeignKey("TrangThaiId")]
        public TrangThaiTonKho TrangThai { get; set; }

        [DefaultValue(1)]
        public int NhaCungCapId { get; set; }
        [ForeignKey("NhaCungCapId")]
        public NhaCungCap NhaCungCap { get; set; }
        [Required]
        public DateTime NgayNhap { get; set; }

        [Required]
        public DateTime NgayHetHan { get; set; }
    }
}

