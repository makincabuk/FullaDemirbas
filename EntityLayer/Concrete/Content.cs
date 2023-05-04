using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    class Content
    {
        public int ContentId { get; set; }
        public string ContentValue { ge t; set; }
        public string ContentDate { get; set; }

        public  int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
