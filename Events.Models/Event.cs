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
        [Required]
        public string ActiveRecipientsJson
        {
            get
            {
                if (ActiveRecipients != null)
                {

                    return JsonConvert.SerializeObject(ActiveRecipients);
                }
                return JsonConvert.SerializeObject(new List<string>());
            }
            set
            {
                if (value != null)
                {
                    ActiveRecipients = JsonConvert.DeserializeObject<List<string>>(value);
                }

            }
        }

        [NotMapped]
        //[JsonProperty("activeRecipients")]
        public List<string> ActiveRecipients { get; set; }

        [JsonIgnore]
        [Required]
        public string NotActiveRecipientsJson {
            get
            {
                if (NotActiveRecipients != null)
                {
                    return JsonConvert.SerializeObject(NotActiveRecipients);
                }
                return JsonConvert.SerializeObject(new List<string>());

            }
            set
            {
                if (value != null)
                {
                    NotActiveRecipients = JsonConvert.DeserializeObject<List<string>>(value);
                }

            }

        }

        [NotMapped]
        [JsonProperty("notActiveRecipients")]
        public List<string> NotActiveRecipients{ get; set; }

        [Required]
        public DateTime RowCreateDate { get; set; }
        [Required]
        public bool IsMailSent { get; set; }
        [ForeignKey("EventCatetogory")]
        public int EventTypeId { get; set; }
        public EventCatetogory EventCatetogory { get; set; }
    }
}
