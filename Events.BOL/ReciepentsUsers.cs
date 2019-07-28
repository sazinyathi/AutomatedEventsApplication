using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Events.BOL
{
    [Table("ReciepentsUsers")]
    public class ReciepentsUsers
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsersID { get; set; }
        [JsonProperty("ActiveRecipients")]
        [Required]
        public string ActiveRecipients { get; set; }
        [Required]
        [JsonProperty("NotActiveRecipients")]
        public string NotActiveRecipients { get; set; }
        
        public bool IsEmailSent { get; set; }
        [ForeignKey("Events")]
        public int Id{ get; set; }
        
    }
}
