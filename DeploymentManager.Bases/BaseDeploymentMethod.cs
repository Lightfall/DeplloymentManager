using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Bases
{
    public abstract class BaseDeploymentMethod
    {
        private Dictionary<string, string> _configuration;

        protected Dictionary<string, string> Configuration
        {
            get { return _configuration ?? (_configuration = new Dictionary<string, string>()); }
            //set { _configuration = value; }
        }

        private List<string> _files;

        public List<string> Files
        {
            get { return _files ?? (_files = new List<string>()); }
            //set { _files = value; }
        }

        public string Name { get; set; }

        public abstract void Deploy();

    }
}
