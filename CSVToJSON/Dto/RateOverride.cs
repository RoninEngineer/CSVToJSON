using System;
using System.Collections.Generic;
using System.Text;

namespace CSVToJSON.Dto
{
    public class RateOverride
    {
        public int ClientId { get; set; }
        public long OrgUid { get; set; }
        public string LineItemCode { get; set; }
        public decimal Rate { get; set; }
    }
}
