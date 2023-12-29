using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class ChiTietHoaDon {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HoaDonId { get; set; }

        [ForeignKey("HoaDonId")]
        public HoaDon HoaDon { get; set; }

        [Required]
        public int MonAnId { get; set; }

        [ForeignKey("MonAnId")]
        public MonAn MonAn { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        public decimal ThanhTien { get; set; }
       

    }
}
