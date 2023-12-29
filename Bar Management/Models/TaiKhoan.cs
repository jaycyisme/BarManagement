using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class TaiKhoan {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [Required]
        [MaxLength(50)]
        public string MatKhau { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public int? NhanVienId { get; set; }

        [ForeignKey("NhanVienId")]
        public NhanVien NhanVien { get; set; }

        public int? SettingId { get; set; }

        [ForeignKey("SettingId")]
        public Setting Setting { get; set; }
    }
}
