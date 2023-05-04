﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(100)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee  Employee  { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}