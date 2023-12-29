﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public class BaseEntity {
        public BaseEntity(Int64 id) {
            Id = id;
        }

        [Key]
        public Int64 Id {
            get;
            set;
        }
        public DateTime AddedDate {
            get;
            set;
        }
        public DateTime ModifiedDate {
            get;
            set;
        }
        public string IPAddress {
            get;
            set;
        }


    }
}
