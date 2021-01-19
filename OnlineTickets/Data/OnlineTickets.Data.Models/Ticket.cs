using OnlineTickets.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTickets.Data.Models
{
    public class Ticket : BaseDeletableModel<string>
    {
        public Ticket()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public string Qr { get; set; }

        public double Price { get; set; }
    }
}
