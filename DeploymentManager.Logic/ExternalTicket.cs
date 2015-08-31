using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeploymentManager.Logic
{
    public class ExternalTicket
    {

        public ExternalTicket()
        {
            FilesToDeploy = new Dictionary<int, Subject>();
        }

        /// <summary>
        /// Ticket in dahil olduğu proje
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Ticket tan sorumlu olan kullanıcı
        /// </summary>
        public User User { get; set; }

        private InternalTicket _internalTicket;

        public InternalTicket InternalTicket
        {
            get { return _internalTicket; }
            set
            {
                _internalTicket = value;
                _internalTicket.ExternalTickets.Add(this);
            }
        }

        /// <summary>
        /// Deploy edilecek dosyalar
        /// </summary>
        public Dictionary<int, Subject> FilesToDeploy { get; set; }

        //TODO : GENEL BİLGİLER
        public string Name { get; set; }


        public override string ToString()
        {
            return Name;
        }

    }
}
