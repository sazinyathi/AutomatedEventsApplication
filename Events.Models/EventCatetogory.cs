using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Events.Models
{
    [Table("EventCatetogory")]
    public class EventCatetogory
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public IEnumerable<Event> Event { get; set; }
    }
}
