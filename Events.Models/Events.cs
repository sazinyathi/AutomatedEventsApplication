using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.BOL
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
        public DateTime EventDate { get; set; }
        [ForeignKey("EventCatetogory")]
        public int EventTypeId { get; set; }
        public EventCatetogory EventCatetogory { get; set; }
    }
}
