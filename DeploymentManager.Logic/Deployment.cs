using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Logic
{
    public class Deployment
    {
        public Deployment()
        {
            InternalTickets = new List<InternalTicket>();
        }
        /// <summary>
        /// Planlanan Deployment zamanı
        /// </summary>
        public DateTime ScheduledTime { get; set; }

        /// <summary>
        /// Deployment'a konu olan ticketlar
        /// </summary>
        public List<InternalTicket> InternalTickets { get; set; }

        /// <summary>
        /// Planlanmış Deployment'ın gerçekleşmesini sağlar
        /// </summary>
        public void ExecuteDeploy()
        {
            if (HasEmptySubject())
            {
                throw new DeploymentManager.Bases.BussinessException("Dosyası olmayan yada Deployment Methodu belli olmayan dosya mevcuttur.");
            }
            foreach (var internalTicket in InternalTickets)
            {
                foreach (var externalTicket in internalTicket.ExternalTickets)
                {
                    externalTicket.FilesToDeploy.OrderBy(x => x.Key).ToList().ForEach(s => s.Value.ExecuteDeploy());
                }
            }
        }

        private bool HasEmptySubject()
        {
            return InternalTickets.Any(i => i.ExternalTickets.Any(e => e.FilesToDeploy.Count == 0 || e.FilesToDeploy.Any(kv => kv.Value == null)));
        }

        //TODO : GENEL BİLGİLER
        public string ReleaseId { get; set; }



        public override string ToString()
        {
            return ReleaseId;
        }

    }
}
