using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class CongThuc {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MonAnId { get; set; }

        [ForeignKey("MonAnId")]
        public MonAn MonAn { get; set; }

        [Required]
        public int NguyenLieuId { get; set; }

        [ForeignKey("NguyenLieuId")]
        public NguyenLieu NguyenLieu { get; set; }

        [Required]
        [MaxLength(20)]
        public string DonVi { get; set; }

        [Required]
        public int SoLuong { get; set; }
    }
}
