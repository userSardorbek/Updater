using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Updater.Model.Enums;

namespace Updater.Model
{
    [Table("Load")]
    public class Load
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string LoadNumber { get; set; }
        public LoadType PickUpType { get; set; }
        public LoadType DeliverType { get; set; }
        public string ReferenceNumbers { get; set; } // Route&Trip, SID, BOL etc
        public LoadStatus LoadStatus { get; set; } 

        public int? BrokerId { get; set; }   
        public Broker? Broker { get; set; }

        public int? TeamId { get; set; }   
        public Team? Team { get; set; }

        public string? BookedById { get; set; }
        public User? BookedBy { get; set; }
    }
}