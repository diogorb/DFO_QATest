using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DFO_QATest_UserAPI.Models
{
    public class Users
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(12, 150)]
        public int Age { get; set; }
        
        [StringLength(50)] 
        public string Address { get; set; }
    }
}
