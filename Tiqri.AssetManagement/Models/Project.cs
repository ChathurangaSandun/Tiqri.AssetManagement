using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
