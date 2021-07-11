using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.DataModels
{
    [Table("users_tbl")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }
        public string Username { get; set; }
        public string  Password{ get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
        public byte[] UserImage { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string LastConnectionId { get; set; }
    }
}
