using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZenithWebSite.Models.Entity
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eventId { get; set; }
        //saved as "dd-MM-yyyy hh:mm:ss"
        public DateTime eventFrom { get; set; }
        public DateTime eventTo { get; set; }
        public string Username { get; set; }
        [Display(Name = "Create Time")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime createEvent { get; set; }
        public bool isActive { get; set; }

        public int activityId { get; set; }
        [ForeignKey("activityId")]
        public Activity Activity { get; set; }


    }
}