using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Logic
{
    public class User
    {
        /// <summary>
        /// Kullanıcının görevi
        /// </summary>
        public Roles Role { get; set; }

        /// <summary>
        /// Kullanıcının bağlı olduğu tedarikçi
        /// </summary>
        public Supplier Supplier { get; set; }
        
        //TODO : GENEL BİLGİLER
        public string Name { get; set; }

        

    }
}
