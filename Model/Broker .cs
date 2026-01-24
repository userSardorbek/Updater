using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Updater.Model
{
    [Table("Broker")]
    public class Broker
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; }
        public string extraPhoneNumber { get; set; }
        public string extraEmail { get; set; }
        public string TrackingApp { get; set; }
        public string ExtraInfo { get; set; }

        public List<Load> Loads { get; set; } = [];
    }
}