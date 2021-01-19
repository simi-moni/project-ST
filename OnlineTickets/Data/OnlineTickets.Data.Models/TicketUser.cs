using OnlineTickets.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTickets.Data.Models
{
    public class TicketUser : BaseDeletableModel<string>
    {
        public TicketUser()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public virtual Ticket Ticket { get; set; }

        public string TicketId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string UserId { get; set; }
    }
}
