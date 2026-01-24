using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Updater.Model
{
    [Table("Team")]
    public class Team
    {
        public int Id { get; set; }
        public string TruckNumber { get; set; } = string.Empty;
        
        public string? UserId { get; set; }
        public User? User { get; set; }

        public string[] NotAllowedList { get; set; } = [];

        public List<Driver> Drivers { get; set; } = [];
    }
}