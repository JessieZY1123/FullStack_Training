using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerCRM.Core.Models
{
    // To take HTTP response and request
    public class RegionModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Region Name is required")]
        [MaxLength(50,ErrorMessage ="Region Name can be maximunm 50 character allowed")]
        public string Name { get; set; }
    }
}
