﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class Dinner
    {
        public int DinnerId { get; set; }
        public string Title { get; set; }
        [DisplayName("Event Date")]
        public DateTime EventDate { get; set; }
        public string Address { get; set; }
        [DisplayName("Hosted By")]
        public string HostedBy { get; set; }
        public string Country { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }
    }
}