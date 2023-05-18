using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID{ get; set; }
        [StringLength(100)]
        public string Username { get; set; }
        [StringLength(100)]
        public string UserSurName { get; set; }
        [StringLength(1000)]
        public string Usermage { get; set; }
        [StringLength(100)]
        public string UserMail { get; set; }
        [StringLength(100)]
        public string UserPassword { get; set; }
        public ICollection<Fixture> fixtures { get; set; }
    }
}
