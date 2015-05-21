using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Logic
{
    public class Deployment
    {
        /// <summary>
        /// Planlanan Deployment zamanı
        /// </summary>
        public DateTime ScheduledTime { get; set; }

        /// <summary>
        /// Deployment'a konu olan ticketlar
        /// </summary>
        public List<InternalTicket> InternalTickets { get; set; }

        //TODO : GENEL BİLGİLER

    }
}
