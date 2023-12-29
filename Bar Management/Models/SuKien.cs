using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class SuKien {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenSuKien { get; set; }

        [Required]
        public DateTime NgayDienRa { get; set; }

        [MaxLength(100)]
        public string MoTa { get; set; }
    }
}
