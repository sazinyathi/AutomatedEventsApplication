using Events.Models.DTOs;
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
        public Event()
        {
            ActiveRecipients = new List<string> {"nolwazi@gmail.com","Sbusiso@yahoo.com","Vezi@Hotmail.com" };
            NotActiveRecipients = new List<string> { "sazi.nyathi@lexisnexis.co.za", "pravin@sa.com", "senzo@thebugs.com" };
        }
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventName { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventDescription { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventLocation { get; set; }
        [JsonIgnore]
        public string ActiveRecipientsJson { get; set; }

        [NotMapped]
        [JsonProperty("activeRecipients")]
        public List<string> ActiveRecipients
        {
            get
            {
                if (!string.IsNullOrEmpty(ActiveRecipientsJson))
                {
                    return JsonConvert.DeserializeObject<List<string>>(ActiveRecipientsJson);
                }
                return new List<string>();
            }
            set
            {
                if (value != null)
                {
                    ActiveRecipientsJson = JsonConvert.SerializeObject(value);
                }

            }

        }

        [JsonIgnore]
        public string NotActiveRecipientsJson { get; set; }

        [NotMapped]
        [JsonProperty("notActiveRecipients")]
        public List<string> NotActiveRecipients
        {
            get
            {
                if (!string.IsNullOrEmpty(NotActiveRecipientsJson))
                {
                    return JsonConvert.DeserializeObject<List<string>>(NotActiveRecipientsJson);
                }
                return new List<string>();

            }
            set
            {
                if (value != null)
                {
                    NotActiveRecipientsJson = JsonConvert.SerializeObject(value);
                }

            }

        }

        [Required]
        public DateTime RowCreateDate { get; set; }
        [Required]
        public bool IsMailSent { get; set; }
        [ForeignKey("EventCatetogory")]
        public int EventTypeId { get; set; }
        public EventCatetogory EventCatetogory { get; set; }
    }
}
