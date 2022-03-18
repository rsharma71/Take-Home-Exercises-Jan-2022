﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWatchSystem.Entities
{
    [Table("DbVersion")]
 
        public class DbVersion
        {
            [Key]
            public int Id { get; set; }
            public int Major { get; set; }
            public int Minor { get; set; }
            public int Build { get; set; }
            public DateTime ReleaseDate { get; set; }
        }
    
}
