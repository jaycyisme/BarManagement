using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO {
    public class SettingDto {
        public SettingDto() {
        }

        public int Id { get; set; }
        public string NgonNgu { get; set; }

        public SettingDto(int id, string ngonNgu) {
            Id = id;
            NgonNgu = ngonNgu;
        }
    }
}
