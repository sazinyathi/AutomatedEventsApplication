using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Models
{
    [Table("Events")]
    public class Event
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventName { get; set; }
        [Required]
        [MaxLength(50)]
        public string  EventDescription { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventLocation { get; set; }
        [Required]
        [JsonProperty("ActiveRecipients")]
        public List<Reciepents> ActiveRecipients { get; set; }
        
        [Required]
        public DateTime RowCreateDate { get; set; }
        [ForeignKey("EventCatetogory")]
        public int EventTypeId { get; set; }
        public EventCatetogory EventCatetogory { get; set; }
    }
}
