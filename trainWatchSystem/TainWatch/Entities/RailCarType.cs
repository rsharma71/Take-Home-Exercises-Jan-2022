using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrainWatchSystem.Entities
{
    [Table("RailCarTypes")]
    public class RailCarType
    {
        [Key]
        public int RailCarTypeID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name is limited to 20 characters")]
        public string Name{ get; set; }

        [Required(ErrorMessage = "Commodity is required")]
        [StringLength(100, ErrorMessage = "Commodity is limited to 100 characters")]
        public string Commodity { get; set; }
    }
}
