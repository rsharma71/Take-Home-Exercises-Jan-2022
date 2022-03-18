using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainWatchSystem.Entities
{

    [Table("RollingStock")]
        public class RollingStock
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            [StringLength(24, MinimumLength = 1, ErrorMessage = "ReportingMark is required and limited to 20 characters")]
            public string ReportingMark { get; set; }
            [Required(ErrorMessage = "Owner Name is required")]
            [StringLength(50, ErrorMessage = "Owner Name is limited to 50 characters")]
            public string Owner { get; set; }

            public int LightWeight { get; set; }
        public int LoadLimit { get; set; }
        public int Capacity { get; set; }
        public int RailCarTypeID { get; set; }
        public int YearBuilt { get; set; }
        public Boolean InSerivice { get; set; }
        [Required(ErrorMessage = "Notes are required")]
        [StringLength(250, ErrorMessage = "Notes are limited to 250 characters")]
        public string Notes { get; set; }

    }

}
