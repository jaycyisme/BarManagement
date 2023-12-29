using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class NhanVien {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        [MaxLength(11)]
        public string SDT { get; set; }

        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string HinhAnh { get; set; }

        [DefaultValue(0)]
        public decimal Luong { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
