using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Bases
{
    public class DeploymentException : Exception
    {
        public DeploymentException()
            : base()
        {

        }
        public DeploymentException(string message)
            : base(message)
        {

        }

        public DeploymentException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
