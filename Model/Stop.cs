using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Updater.Model.Enums;

namespace Updater.Model
{
    [Table("Stop")]
    public class Stop
    {
        public Guid Id { get; set; }
        public bool CheckOut { get; set; }
        public Timezone Timezone { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime Checkedout { get; set; }
    }
}