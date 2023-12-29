using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class Ban {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenBan { get; set; }

        [Required]
        public int TrangThaiId { get; set; }

        [ForeignKey("TrangThaiId")]
        public TrangThaiBan TrangThai { get; set; }

        [MaxLength(100)]
        public string GhiChu { get; set; }
    }
}
