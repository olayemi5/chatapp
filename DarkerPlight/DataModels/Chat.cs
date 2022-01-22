using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.DataModels
{
    [Table("Chats_tbl")]
    public class Chat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ChatId { get; set; }
        public string Message { get; set; }
        public string UserIdOne { get; set; }
        public string UserIdTwo { get; set; }
        public DateTime ChatTime { get; set; }
        public bool IsGroup { get; set; }
        public int GroupNumber { get; set; }
        public string SentBy { get; set; }
        public string Recipient { get; set; }
    }
}
