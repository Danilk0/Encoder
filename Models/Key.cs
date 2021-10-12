using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProektTRPO.Models
{
    public class Key
    {
        public int Id { get; set; }
        public string Keys { get; set; }
        public string EncryptedData { get; set; }

        public  int? UserId { get; set; }
        public User User { get; set; }

       
    }
}
