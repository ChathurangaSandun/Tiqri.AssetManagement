using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class Asset
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Status { get; set; }

        public long LocationId { get; set; }
        public long ProjectId { get; set; }
        public long AssetTypeId { get; set; }
        public long UserId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Project Project{ get; set; }
        public virtual AssetType AssetType{ get; set; }
        public virtual User User { get; set; }

    }
}
