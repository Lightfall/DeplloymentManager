using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeploymentManager.Bases;

namespace DeploymentManager.Logic
{
    /// <summary>
    /// Kullanılacak dosya tipleri
    /// </summary>
    /// <remarks>Kullanıcı tarafından sisteme tanımlanacak.</remarks>
    public class FileType
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public BaseDeploymentMethod DefaultDeploymentMethod { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
