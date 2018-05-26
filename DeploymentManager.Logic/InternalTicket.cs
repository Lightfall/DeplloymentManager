using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeploymentManager.Logic
{
    /// <summary>
    /// Müşteri firmanın talepleridir.
    /// Örnek: WebSitesinde borç bilgileri görüntülenebilmelidir.
    /// </summary>
    public class InternalTicket
    {
        public InternalTicket()
        {
            ExternalTickets = new List<ExternalTicket>();
        }
        public List<ExternalTicket> ExternalTickets { get; set; }

        //TODO : GENEL BİLGİLER
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
