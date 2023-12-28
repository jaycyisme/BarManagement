using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    internal class TrangThaiTonKho {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), DataType("nvarchar")]
        public string Ten { get; set; }
    }
}
