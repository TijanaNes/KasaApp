﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Updated { get; set; }
        public DateTime? Date_Deleted { get; set; }
    }
}
