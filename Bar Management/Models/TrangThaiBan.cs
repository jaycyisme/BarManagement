using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class TrangThaiBan {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Ten { get; set; }
    }
}
