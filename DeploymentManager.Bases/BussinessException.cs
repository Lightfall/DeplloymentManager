using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentManager.Bases
{
    public class BussinessException : Exception
    {
        public BussinessException()
            : base()
        {

        }
        public BussinessException(string message)
            : base(message)
        {

        }

        public BussinessException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
