using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class AssetType
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }
}
