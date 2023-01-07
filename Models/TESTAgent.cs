using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_TEST_API.Models
{
    [Table("V_Agent")]
    public class TESTAgent
    {
        [Key]
        public int Auto_Id { get; set; }
        public string CODE { get; set; }
        public string ID_NBR { get; set; }
    }
}
