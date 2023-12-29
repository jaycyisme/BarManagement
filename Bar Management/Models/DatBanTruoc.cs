using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class DatBanTruoc {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BanId { get; set; }

        [ForeignKey("BanId")]
        public Ban Ban { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenNguoiDat { get; set; }

        [Required]
        public int TaiKhoanDatId { get; set; }

        [ForeignKey("TaiKhoanDatId")]
        public TaiKhoan TaiKhoanDat { get; set; }

        [Required]
        [MaxLength(11)]
        public string SDT { get; set; }

        [Required]
        public DateTime NgayDat { get; set; }

        [Required]
        public DateTime NgaySuDung { get; set; }

        [MaxLength(100)]
        public string MoTa { get; set; }
    }
}
