using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class NhaCungCap {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [MaxLength(100)]
        public string DiaChi { get; set; }

        [Required]
        [MaxLength(11)]
        public string Sdt { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
