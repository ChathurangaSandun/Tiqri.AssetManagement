using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class Location
    {

        public long Id { get; set; }
        public string LocationName { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
