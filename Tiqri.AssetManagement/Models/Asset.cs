using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class Asset
    {
        public long Id { get; set; }
        public string AssetId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }
        public string Project { get; set; }
        public string AssetType { get; set; }
        public string User { get; set; }

        

    }
}
