using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class Setting {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string NgonNgu { get; set; }
    }
}
