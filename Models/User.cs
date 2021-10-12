using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProektTRPO.Models
{
    public class User
    {
        public User()
        {
            this.UserKeys = new HashSet<Key>();
        }
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Key> UserKeys { get;  set; }

        
    }
}
