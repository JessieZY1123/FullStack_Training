﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRM.Core.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters are allowed")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }


        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }
        public int RegionId { get; set; }
        public int PostalCode { get; set; }
  
        [Required]
        public string Country { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Photo { get; set; }
    }
}
