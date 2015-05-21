using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeploymentManager.Logic
{
    public class ExternalTicket
    {
        /// <summary>
        /// Ticket in dahil olduğu proje
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Ticket tan sorumlu olan kullanıcı
        /// </summary>
        public User User { get; set; }


        //TODO : GENEL BİLGİLER

        /// <summary>
        /// Deploy edilecek dosyalar
        /// </summary>
        public Dictionary<int, Subject> FilesToDeploy { get; set; }



    }
}
