using DeploymentManager.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeploymentManager.Logic
{
    public class Subject
    {
        public string FileName { get; set; }
        public FileType FileType { get; set; }

        public BaseDeploymentMethod DeploymentMethod { get; set; }

        internal void ExecuteDeploy()
        {
            DeploymentMethod.Files.Add(Configuration.BaseDirectory + FileName);
            DeploymentMethod.Deploy();
        }


        public override string ToString()
        {
            return FileName + "-" + DeploymentMethod.ToString();
        }

    }
}
