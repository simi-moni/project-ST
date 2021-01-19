using OnlineTickets.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTickets.Data.Models
{
    public class Vehicle : BaseDeletableModel<string>
    {
        public Vehicle()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Type { get; set; }

        public string Number { get; set; }
    }
}
