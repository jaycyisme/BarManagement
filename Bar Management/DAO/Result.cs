using System;
using System.Collections.Generic;
using System.IdentityModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public class Result {
        public bool IsSuccess { get; set; } = false;
        public object Data { get; set; } = null;
        public string Message { get; set; } = "";

    }
}
